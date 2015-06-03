﻿using PhotoStory.Data.Relational.Entities.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoModel = PhotoStory.Models.Photo.Photo;

namespace PhotoStory.Data.Relational.Entities.Photo {

	public class Photo : Entity<PhotoModel> {

		public int ID { get; set; }

		public DateTime UploadTime { get; set; }

		public string Key { get; set; }

		public string FileName { get; set; }

		public int UserID { get; set; }

		public virtual User User { get; set; }
	}
}