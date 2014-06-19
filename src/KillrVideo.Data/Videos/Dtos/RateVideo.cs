﻿using System;

namespace KillrVideo.Data.Videos.Dtos
{
    /// <summary>
    /// DTO for rating a video.
    /// </summary>
    [Serializable]
    public class RateVideo
    {
        public Guid VideoId { get; set; }
        public Guid UserId { get; set; }
        public int Rating { get; set; }
    }
}
