class MediaFile
{
    public virtual void Play()
    {
        Console.WriteLine("Playing media");
    }
}

class AudioFile : MediaFile
{
    public override void Play()
    {
        Console.WriteLine("Playing audio file");
    }
}

class VideoFile : MediaFile
{
    public override void Play()
    {
        Console.WriteLine("Playing video file");
    }
}

class ImageFile : MediaFile
{
    public override void Play()
    {
        Console.WriteLine("Displaying image file");
    }
}