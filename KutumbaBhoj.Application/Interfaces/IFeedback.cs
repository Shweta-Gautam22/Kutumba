using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public interface IFeedback
    {
        Task<List<Feedback>> GetAllFeedbacks();

        Task<List<Feedback>> AddFeedbacks(Feedback i);

        Task<Feedback> GetSingleFeedback(int id);

        Task<Feedback> UpdateFeedback(int id, Feedback Request);

        Task<List<Feedback>> DeleteFeedback(int id);
    }
}
