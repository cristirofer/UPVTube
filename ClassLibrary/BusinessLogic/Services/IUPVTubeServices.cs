using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;
using static UPVTube.Services.UPVTubeService;

namespace UPVTube.Services {
    public interface IUPVTubeService {
        void RegisterNewUser(string Email, string FullName, string Nick, string Password);
        void LogIn(String nick, String password);
        void LogOut();
        void UploadNewContent(string title, string description, string URI, bool isPublic, List<Subject> l);
        List<Content> SearchContent(DateTime startDate, DateTime endDate, String nick, String wordsTitle, string subject);
        Details DisplayContentDetails(Content content);
        void AddRewiewToPendingContent(Content content, String justification);
        void AddSubject(Subject subject);
        void RemoveAllData();
        void Commit();
        void DBInitialization();
        bool ImTeacher();
        void AuthoriseContent(Content c);
        void RejectContent(Content c);
        List<Subject> totalCurrentSubjects();
        List<Subject> GetSubjects();
        Boolean isMember();

        List<Content> SearchUnAthorisedContent();

    }
}
