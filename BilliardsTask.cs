namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// Метод возвращает угол отскока шарика от стены по углу направления движения шара и углу
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns>Угол отскока шарика от стены</returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        { 
            return 2 * wallInclinationRadians - directionRadians;
        }
    }
}