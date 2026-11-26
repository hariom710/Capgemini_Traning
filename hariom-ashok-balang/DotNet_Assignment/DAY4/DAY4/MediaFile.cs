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
        Console.WriteLine("Playing audio");
    }
}

class VideoFile : MediaFile
{
    public override void Play()
    {
        Console.WriteLine("Playing video");
    }
}

class ImageFile : MediaFile
{
    public override void Play()
    {
        Console.WriteLine("Showing image");
    }
}