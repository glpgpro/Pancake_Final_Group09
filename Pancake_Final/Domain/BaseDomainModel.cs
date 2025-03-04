﻿namespace Pancake_Final.Domain
{
    public class BaseDomainModel
    {

        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string? CreatedBy    { get; set; }

        public string? UpdateBy { get; set; }

    }
}
