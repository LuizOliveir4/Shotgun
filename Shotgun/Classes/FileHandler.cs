using Shotgun.Classes;
using System.Media;

namespace Shotgun.Classes
{
    public class FileHandler
    {
        //Path plus namn på filen minus sifran mellan 0 och 4 i slutet på filnamn.
        //Filnamnstilläg (filtyp finns med inne i metoderna)
        private string _pathLeftImage = @"C:\Users\PARLUOL03\source\repos\Shotgun\Shotgun\img\LeftMoveCase";
        private string _pathRightImage = @"C:\Users\PARLUOL03\source\repos\Shotgun\Shotgun\img\RightMoveCase";
        private string _pathSoundEffect = @"C:\Users\PARLUOL03\source\repos\Shotgun\Shotgun\sound\MoveCase";

        public string PathLeftImage (int moveCase)
        {
            return _pathLeftImage + moveCase + ".jpg";
        }
        public string PathRightImage(int moveCase)
        {
            return _pathRightImage + moveCase + ".jpg";
        }
        public void PlaySoundEffect(int moveCase)
        {
            SoundPlayer simpleSound = new SoundPlayer(_pathSoundEffect + moveCase + ".wav");
            simpleSound.Play();
        }
    }
}
