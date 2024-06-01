using StudentskiResoranVŽ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Repositories
{
    public class ReviewRepository
    {
        private Dictionary<int, Review> _reviewsByOrderId;

        public ReviewRepository()
        {
            _reviewsByOrderId = new Dictionary<int, Review>();
        }

        public void SaveReview(Review review)
        {
            if (_reviewsByOrderId.ContainsKey(review.OrderItemId))
            {
                _reviewsByOrderId[review.OrderItemId] = review;
            }
            else
            {
                _reviewsByOrderId.Add(review.OrderItemId, review);
            }
        }

        public Review GetReviewByOrderId(int orderId)
        {
            if (_reviewsByOrderId.ContainsKey(orderId))
            {
                return _reviewsByOrderId[orderId];
            }
            else
            {
                return null;
            }
        }

        public void DeleteReviewByOrderId(int orderId)
        {
            if (_reviewsByOrderId.ContainsKey(orderId))
            {
                _reviewsByOrderId.Remove(orderId);
            }
        }

        public List<Review> GetAllReviews()
        {
            return _reviewsByOrderId.Values.ToList();
        }
    }
}
