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
        private List<Review> _reviews;

        public ReviewRepository()
        {
            _reviews = new List<Review>();
        }

        public void SaveReview(Review review)
        {
            _reviews.Add(review);
        }
    }
}
