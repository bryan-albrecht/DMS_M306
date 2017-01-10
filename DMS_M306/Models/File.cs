﻿using DMS_M306.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS_M306.Models
{
    public class File
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastModified { get; set; }

        public PhysicalStorage PhysicalStorage { get; set; }

        public User CreatedBy { get; set; }

        public User LastModifiedBy { get; set; }

        public FileStorageType StorageType { get; set; }

        public FileClass Class { get; set; }

        public FileStatus Status { get; set; }

    }
}