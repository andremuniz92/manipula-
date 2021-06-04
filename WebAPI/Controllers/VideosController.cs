using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public VideosController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Video>> GetVideos()
        {
            return await _videoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Video>> GetVideos(int id)
        {
            return await _videoRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Video>>PostVideos([FromBody] Video video)
        {
            var newVideo = await _videoRepository.Create(video);
            return CreatedAtAction(nameof(GetVideos), new { id = newVideo.Id }, newVideo);
        }

        [HttpPut]
        public async Task<ActionResult> PutVideos(int id, [FromBody] Video video)
        {
            if(id != video.Id)
            {
                return BadRequest();
            }

            await _videoRepository.Update(video);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            var videoToDelete = await _videoRepository.Get(id);
            if (videoToDelete == null)
                return NotFound();

            await _videoRepository.Delete(videoToDelete.Id);
            return NoContent();
        }

    }
}
