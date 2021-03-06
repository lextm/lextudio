using System;
using System.IO;
using System.Windows.Forms;

namespace BeWise.Common.IconManagers {
	/// <summary>
	/// File icon manager.
	/// </summary>
    public class FileIconManager : BaseIconManager, IDisposable {
		
		/// <summary>
		/// Constructor.
		/// </summary>
        public FileIconManager() {
            imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
        }

        // *********************************************************************
        //                           Private
        // *********************************************************************
        private ImageList imageListLarge = new ImageList();

        // *********************************************************************
        //                           Public
        // *********************************************************************
        /// <summary>
        /// Gets image index.
        /// </summary>
        /// <param name="key">File path</param>
        /// <param name="selected">Selected flag</param>
        /// <returns>Index.</returns>
        public override int GetImageIndex(string key, bool selected) {
            if (!(Directory.Exists(key) || Lextm.IO.FileHelper.FileIsValid(key))) {
                return -1;
            }

            string _Extension = Path.GetExtension(key);
            if (string.IsNullOrEmpty(_Extension)) {
                _Extension = key;
            }

            int _Index = base.GetImageIndex(_Extension, selected);

            if (_Index == -1) {
                imageListLarge.Images.Add(ExtractIcons.GetIcon(key, selected, false));
                _Index = base.AddImage(_Extension, ExtractIcons.GetIcon(key, selected, true).ToBitmap(), selected);
            }
            return _Index;
        }

        // *********************************************************************
        //                           Properties
        // *********************************************************************
        /// <summary>
        /// Image list large.
        /// </summary>
        public ImageList ImageListLarge {
            get {
                return imageListLarge;
            }
        }
		/// <summary>
		/// Image list small.
		/// </summary>
        public ImageList ImageListSmall {
            get {
                return ImageList;
            }
        }
    	
		private bool _disposed;
		/// <summary>
		/// Disposes of the resources (other than memory) used by the <see cref="FileIconManager"/>.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources. 
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (_disposed) {
				return;
			}
			if (disposing) {
				imageListLarge.Dispose();
			}
			base.Dispose(disposing);
			_disposed = true;
		}		
    }
}

