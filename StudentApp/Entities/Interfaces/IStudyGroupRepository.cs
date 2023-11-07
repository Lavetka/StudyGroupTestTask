using TestApp;

namespace StudentApp.StudyGroupFeature.Entities.Interfaces
{
    public interface IStudyGroupRepository
    {
        Task CreateStudyGroup(StudyGroup studyGroup);
        Task<List<StudyGroup>> GetStudyGroups();
        Task<List<StudyGroup>> GetSortedStudyGroups(bool asc = true);
        Task<List<StudyGroup>> SearchStudyGroups(string subject);
        Task JoinStudyGroup(int studyGroupId, int userId);
        Task LeaveStudyGroup(int studyGroupId, int userId);
    }
}



