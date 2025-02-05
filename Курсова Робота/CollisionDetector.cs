using System.Windows.Forms;

namespace Курсова_Робота
{
    public static class CollisionDetector
    {
        public static bool CheckCollision(PictureBox obj1, PictureBox obj2)
        {
            return obj1.Bounds.IntersectsWith(obj2.Bounds);
        }
    }
}