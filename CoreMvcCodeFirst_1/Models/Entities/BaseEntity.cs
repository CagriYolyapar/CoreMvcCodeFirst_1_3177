﻿using CoreMvcCodeFirst_1.Models.Enums;

namespace CoreMvcCodeFirst_1.Models.Entities
{
    public abstract class BaseEntity
    {
        public int BenimId{ get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
