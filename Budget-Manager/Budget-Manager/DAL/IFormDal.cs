using LyftRecorder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyftRecorder.DAL {
    public interface IFormDal {
        List<FormPost> GetAllPosts();
        bool SaveNewPost(FormPost post);
    }
}
