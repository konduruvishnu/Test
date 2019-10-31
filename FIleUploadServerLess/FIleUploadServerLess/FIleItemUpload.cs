using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIleUploadServerLess
{
    public class FileItemUpload
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreatedTimestamp { get; set; }
    }
}
