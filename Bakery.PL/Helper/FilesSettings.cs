namespace Bakery.PL.Helper
{
    public class FilesSettings
    {


        public static  string UploadFile(IFormFile file,string folderName)
        {
            //1- create the file path
            string folderPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\files",folderName);
            string fileName = $"{ Guid.NewGuid()}{file.FileName}";
            string path = Path.Combine(folderPath, fileName);
            //2- create anew file in this path

            //u make sure the stream is closed as soon as the upload is completed.
            using (var fileStream = new FileStream(path, FileMode.Create)) {
                //3-store the input file in this server(the created file).
                file.CopyTo(fileStream);
            } 
     
          
            return fileName;

        }
        public static  void DeleteFile(string fileName, string folderName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if (File.Exists(path)){
                File.Delete(path);

            }

        }
    }




    
}
