﻿using PhotoStory.Models.Photos;
using PhotoStory.Util.SubModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PhotoStory.ViewModels.Photos {

	public class Photo_ToSave : ViewModel<Photo> {

		[ModelMapping]
		public int UserID { get; set; }

		[ModelMapping]
		public int StoryID { get; set; }

		[ModelMapping]
		public int ChapterID { get; set; }

		[ModelMapping]
		public string FileName { get; set; }

		[ModelMapping]
		public DateTime UploadTime { get; set; }

		[ModelMapping(ModelMappingType: ModelMappingType.ConstructorParameter)]
		public Stream InputStream { get; set; }

		[ModelMapping(ModelMappingDirection: ModelMappingDirection.FromModel)]
		public string Url { get; set; }

		public Photo_ToSave() { }

		public Photo_ToSave(Photo model) : base(model) { }

		public Photo_ToSave(Photo_FromClient photoFromClient, HttpPostedFileBase file) {
			UserID = photoFromClient.UserID;
			StoryID = photoFromClient.StoryID;
			ChapterID = photoFromClient.ChapterID;
			FileName = file.FileName;
			InputStream = file.InputStream;
			UploadTime = DateTime.Now;
		}
	}
}