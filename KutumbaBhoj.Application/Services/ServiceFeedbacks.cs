using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutumbaBhoj.Application.Services
{
    public class ServiceFeedbacks:IFeedback
    {
        private readonly IFeedbackRepository _dishes;

        public ServiceFeedbacks(IFeedbackRepository dishes)
        {
            _dishes = dishes;
        }
        public async Task<List<Feedback>> GetAllFeedbacks()
        {
            return await _dishes.GetAllFeedbacks();
        }

        public async Task<List<Feedback>> AddFeedbacks(Feedback I)
        {
            return await _dishes.AddFeedbacks(I);
        }
        public async Task<Feedback> GetSingleFeedback(int Id)
        {
            return await _dishes.GetSingleFeedback(Id);
        }

        public async Task<Feedback> UpdateFeedback(int Id, Feedback Request)
        {
            return await _dishes.UpdateFeedback(Id, Request);
        }
        public async Task<List<Feedback>> DeleteFeedback(int Id)
        {
            return await _dishes.DeleteFeedback(Id);
        }

    }
}
