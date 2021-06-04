using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly VideoContext _context;

        public VideoRepository(VideoContext context)
        {
            _context = context;
        }

        public async Task<Video> Create(Video video)
        {
            _context.Videos.Add(video);
            await _context.SaveChangesAsync();

            return video;
        }

        public async Task Delete(int id)
        {
            var videoToDelete = await _context.Videos.FindAsync(id);
            _context.Videos.Remove(videoToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Video>> Get()
        {
            return await _context.Videos.ToListAsync();
        }

        public async Task<Video> Get(int id)
        {
            return await _context.Videos.FindAsync(id);
        }

        public async Task Update(Video video)
        {
            _context.Entry(video).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
