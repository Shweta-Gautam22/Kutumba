using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;
using KutumbaBhoj.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Infrastructure.Repository
{
    public class FeedbackRepository:IFeedbackRepository
    {
        private readonly DataContext _dbContext;

        public FeedbackRepository(DataContext DbContext)
        {
            _dbContext = DbContext;
        }
        public async Task<List<Feedback>> GetAllFeedbacks()
        {
            return await _dbContext.Feedbacks.ToListAsync();
        }
        public async Task<List<Feedback>> AddFeedbacks(Feedback i)
        {
            _dbContext.Feedbacks.Add(i);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Feedbacks.ToListAsync();
        }
        public async Task<Feedback> GetSingleFeedback(int id)
        {
            return await _dbContext.Feedbacks.FindAsync(id);
        }
        public async Task<Feedback> UpdateFeedback(int id, Feedback request)
        {
            Feedback existingFeedback = await _dbContext.Feedbacks.FindAsync(id);
            if (existingFeedback != null)
            {
                existingFeedback.Review = request.Review;
                existingFeedback.Date = request.Date;
                await _dbContext.SaveChangesAsync();
            }
            return existingFeedback;
        }
        public async Task<List<Feedback>> DeleteFeedback(int id)
        {
            Feedback existingItem = await _dbContext.Feedbacks.FindAsync(id);
            if (existingItem != null)
            {
                _dbContext.Feedbacks.Remove(existingItem);
                await _dbContext.SaveChangesAsync();
            }
            return await _dbContext.Feedbacks.ToListAsync();
        }

    }
}
