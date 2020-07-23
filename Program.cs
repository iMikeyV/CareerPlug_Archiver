string directoryPath = @"*******SET DIRECTORY HERE*******";
string archivePath = @"*******SET PATH OF ARCHIVE HERE*******";
 
//Gets directory info
DirectoryInfo directory = new DirectoryInfo(directoryPath);
//Array of files with "specified file type" here it is shown as .xml
FileInfo[] Files = directory.GetFiles(".xml");
//Sets a time span of 30 days
TimeSpan timeSpan = new TimeSpan(30,0,0,0);
//checks all the files in the file array
foreach (FileInfo file in Files)
{
    //if file (last modified date is 30 days or older) moves the file to archive path
    if ((DateTime.Now - file.LastWriteTime) > timeSpan)
    {
        File.Move(directoryPath+file, archivePath + file);
    }
}
