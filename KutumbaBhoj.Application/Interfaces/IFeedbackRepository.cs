using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Interfaces
{
    public interface IFeedbackRepository
    {
        Task<List<Feedback>> GetAllFeedbacks();

        Task<List<Feedback>> AddFeedbacks(Feedback i);

        Task<Feedback> GetSingleFeedback(int id);

        Task<Feedback> UpdateFeedback(int id, Feedback Request);

        Task<List<Feedback>> DeleteFeedback(int id);
    }
}
