using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;
using UPVTube.Persistence;

namespace UPVTube.Services {
    public class UPVTubeService : IUPVTubeService {
        private IDAL Dal {
            get; set;
        }
        private Member Logged {
            get; set;
        }
        public UPVTubeService() { }
        public UPVTubeService(IDAL Dal) :this() {
            this.Dal = Dal;
        }

        private Member m;

        public void RegisterNewUser(string Email, string FullName, string Nick, string Password) {
            Member user = new Member(Email, FullName, DateTime.Now, Nick, Password);
            Member a = this.Dal.GetById<Member>(Nick);
            if (a != null) {
                throw new ServiceException("This user already exists");
            } else {
            this.Dal.Insert<Member>(user);
            this.Dal.Commit();
            }
        }
        private Member registerSudoUser(string Email, string FullName, string Nick, string Password)
        {
            Member user = new Member(Email, FullName, DateTime.Now, Nick, Password);
            this.Dal.Insert<Member>(user);
            this.Dal.Commit();
            return user;
        }


    public void LogIn(String nick, String password) {
            Member user = this.Dal.GetById<Member>(nick);
            if(user == null) { throw new ServiceException("The Nickname does not exist!"); }
            else if (password == user.Password) {Logged = user;}
            else throw new ServiceException("Incorrect Password!");
        }

        public void LogOut() {
            if (Logged != null)
            {
                Logged.LastAccessDate = DateTime.Now;
                this.Dal.Commit();
                Logged = null;
            }
        }

        public void UploadNewContent(string title, string description, string URI, bool isPublic, List<Subject> l) {
            if (Logged != null)
            {
                if (Domains.IsTeacherDomain(this.Logged.Email) || Domains.IsStudentDomain(this.Logged.Email))
                {
                    Content c = new Content(URI, description, isPublic, title, DateTime.Now, this.Logged);
                    foreach (Subject s in l) {
                        c.Subjects.Add(s);
                    }
                    this.Dal.Insert<Content>(c);
                    this.Dal.Commit();
                }
                else
                {
                    throw new ServiceException("This user is not allowed to upload new content");
                }
            }
        }
        public List<Subject> GetSubjects() {
            List<Subject> s = Dal.GetAll<Subject>().ToList();
            return s;
        }

        private void sudoUploadNewContent(string title, string description, string URI, bool isPublic)
        {
            Content c = new Content(URI, description, isPublic, title, DateTime.Now, m);
            c.Authorized = Authorized.Yes;
            this.Dal.Insert<Content>(c);
            this.Dal.Commit();
        }

        public List<Content> SearchUnAthorisedContent()
        {
            if (Logged != null)
            {
                List<Content> c = Dal.GetWhere<Content>(cont => cont.Authorized == Authorized.Pending).ToList();
                return c;
            }
            else { return null; }
        }
        public List<Content> SearchContent(DateTime startDate, DateTime endDate, String nick, String wordsTitle, string subject) {
            if (Logged != null)
            {
                //List<Content> c = Dal.GetAll<Content>().ToList();
                List<Content> c = Dal.GetWhere<Content>(cont => cont.Authorized == Authorized.Yes).ToList();
                if (!Domains.IsUPVMemberDomain(Logged.Email))
                    c = c.Where<Content>(cont => cont.IsPublic).ToList();



                if (nick != "")
                {
                    c = c.Where<Content>(cont => cont.Owner.Nick == nick).ToList();
                }

                c = c.Where(cont => cont.UploadDate.CompareTo(startDate) >= 0 && cont.UploadDate.CompareTo(endDate) <= 0).ToList();

                if (wordsTitle != "")
                {
                    c = c.Where(cont =>
                    {
                        bool b = true;
                        if (wordsTitle.Length == 0) return true;
                        string[] words = wordsTitle.Split(' ');
                        foreach (string item in words)
                        {
                            if (cont.Title.Contains(item))
                                b = true;
                            else
                            {
                                b = false;
                                break;
                            }
                        }
                        return b;
                    }).ToList();

                }

                if (subject != "")
                {
                    c = c.Where(cont =>
                    {
                        bool b = false;
                        foreach (Subject s in cont.Subjects)
                        {
                            if (s.Name == subject || s.FullName == subject)
                            {
                                b = true; break;
                            }
                        }
                        return b;
                    }).ToList();
                }


                //devolver la lista ordenada por uploadDate
                return c.OrderBy(cont => cont.UploadDate).ToList();
            } else
            {
                return null;
            }
        }

        public Details DisplayContentDetails(Content content) {
            return new Details(content.Title, content.Owner.Nick, content.Description, content.ContentURI, content.UploadDate, content.IsPublic);

        }

        public void AddRewiewToPendingContent(Content content, String justification) {
            if (Logged != null)
            {
                if (justification == "")
                {
                    throw new ServiceException("A justification must be provided");
                }
                else { this.Dal.Insert<Evaluation>(new Evaluation(DateTime.Now, justification, Logged, content)); Commit(); }
            }
        }

        public void GetAllPendingContent()
        {
                List<Content> c = Dal.GetWhere<Content>(cont => cont.Authorized == Authorized.Pending).ToList();
                c.OrderBy(x => x.UploadDate).ToList();
        }
        public void AddSubject(Subject subject)
        {
            if (Dal.GetById<Subject>(subject.Code) == null)
            {
                // Restriction: Not two courses with same name
                if (!Dal.GetWhere<Subject>(x => x.Name == subject.Name).Any())
                {
                    // Inserting in the DB
                    Dal.Insert<Subject>(subject);
                    Dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + subject.Name + "already exists.");
}
            else
                throw new ServiceException("Subject with code " + subject.Code + "already exists.");
        }

        public void RemoveAllData() {
            Dal.RemoveAllData();
        }

        public void Commit() {
            Dal.Commit();
        }

        public void DBInitialization() {
            RemoveAllData();
            Subject s1 = new Subject(11555, "Ingeniería del software","ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
           
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
           
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);
            m = registerSudoUser("sudo@inf.upv.es", "Sudo", "sudo", "sudo");
            // Añadir los 3 miembros
            RegisterNewUser("test1@gmail.com","Test1", "test1","123");
            RegisterNewUser("test2@inf.upv.es","Test2","test2","456");
            RegisterNewUser("test3@dsic.upv.es","Test3","test3","789");
            // Añadir los 4 contenidos 
            sudoUploadNewContent("ContentTest1", "This content was created to initialize the database.", "www.contentest1.es", true);
            sudoUploadNewContent("ContentTest2", "This content was created to initialize the database.", "www.contentest2.es", true);
            sudoUploadNewContent("ContentTest3", "This content was created to initialize the database.", "www.contentest3.es", false);
            sudoUploadNewContent("ContentTest4", "This content was created to initialize the database.", "www.contentest4.es", false);
        }

        public bool ImTeacher() {
            return Domains.IsTeacherDomain(this.Logged.Email);
        }

        public void AuthoriseContent(Content c) {
            Content cc = Dal.GetById<Content>(c.Id);
            cc.Authorized = Authorized.Yes;
            Commit();
        }

        public void RejectContent(Content c) {
            Content cc = Dal.GetById<Content>(c.Id);
            cc.Authorized = Authorized.No;
            Commit();
        }

        public List<Subject> totalCurrentSubjects()
        {
            return Dal.GetAll<Subject>().ToList();
        }

        public Boolean isMember()
        {
            return Domains.IsUPVMemberDomain(Logged.Email);
        }


        public class Details {
            public string Title;
            public string Author;
            public string Description;
            public string Uri;
            public DateTime UploadDate;
            public bool IsPublic;

            public Details() { }
            public Details(string Title, string Author, string Description, string Uri, DateTime UploadDate, bool IsPublic) :this() {
                this.Title = Title;
                this.Author = Author;
                this.Description = Description;
                this.Uri = Uri;
                this.UploadDate = UploadDate;
                this.IsPublic = IsPublic;
            }
        }

    }
}
