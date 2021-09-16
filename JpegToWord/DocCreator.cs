﻿using Spire.Doc;
using System;

namespace JpegToWord
{
    internal class DocCreator
    {
        public void MergeImagesIntoDoc(string[] images, string output, string filename, string header = null,
            string spacing = null, string run = null)
        {
            Document doc = new Document();
            ImageMerger imageMerger = new ImageMerger();
            imageMerger.MergeImagesIntoDoc(images, doc, header, spacing);
            DocSaver saver = new DocSaver();
            saver.SaveDoc(doc, output, filename);

            Console.WriteLine($"Document was saved to {output}\nfilename: {filename}");

            if (string.IsNullOrEmpty(run))
            {
                return;
            }

            DocStarter starter = new DocStarter();
            starter.StartDocument(output, filename);
        }
    }
}