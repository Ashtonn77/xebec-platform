using BlazorInputFile;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.GamifiedEnvBeta.PhaseTwo.Pages
{
    public partial class AdditionalInfoP3
    {
        private string dropClass = ""; //Not being called
        private bool fileTypeError = false; //Not being called
        private List<IFileListEntry> selectedFiles = new List<IFileListEntry>(); //Stores a list of files from the user

        /*private void HandleDragEnter()
        {
            dropClass = "dropzone-drag";
        }

        private void HandleDragLeave()
        {
            dropClass = "";
        }*/

        private async Task OnInputFileChange(IFileListEntry[] files)
        {
            dropClass = ""; //Can be removed
            fileTypeError = false; //Can be removed
            List<string> acceptedFileTypes = new List<string>() { "image/png", "image/jpeg", "image/gif", "application/pdf", "application/msword" };
            if (files != null)
            {
                foreach (var file in files)
                {
                    bool error = false;

                    if (!acceptedFileTypes.Contains(file.Type))
                    {
                        error = true;
                        fileTypeError = true;
                    }

                    //keep the good files
                    if (!error)
                    {
                        selectedFiles.Add(file);
                    }
                }
            }
            await base.OnInitializedAsync();
        }

        private void RemoveFile(IFileListEntry file)
        {
            selectedFiles.Remove(file);
        }
        //Model used by the form
        public AdditionalInformation AdditionalInformation { get; set; } = new AdditionalInformation();
    }
}
