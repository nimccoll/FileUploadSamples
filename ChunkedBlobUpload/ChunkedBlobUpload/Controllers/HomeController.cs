//===============================================================================
// Microsoft Premier Support for Developers
// Azure Chunked Blob Upload Sample
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
using System;
using System.Web.Mvc;

namespace ChunkedBlobUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.StorageAccount = "nimccollimageuploader";
            ViewBag.Container = "fileupload";
            ViewBag.ApplicationUrl = string.Format("{0}{1}",Request.Url.GetLeftPart(UriPartial.Authority), Url.Content("~/"));

            return View();
        }

        [HttpGet]
        public string GetSas()
        {
            string sasToken = "?sv=2016-05-31&sr=c&sig=0fWLO5bfMiSEHQ7lKIr7m5d4%2BBEn2ik44wz%2BrdjlfFI%3D&se=2017-05-31T18%3A06%3A26Z&sp=rwl";

            return sasToken;
        }
    }
}
