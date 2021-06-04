using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IVideoRepository
    {
        Task<IEnumerable<Video>> Get();
        Task<Video> Get(int id);
        Task<Video> Create(Video video);
        Task Update(Video video);
        Task Delete(int id);

    }
}
