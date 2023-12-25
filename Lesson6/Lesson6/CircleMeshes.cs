using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public static class CircleMeshes
    {
        public static void DrawPolygonPyramid(Vector3 start, float radius, int countAngles, float height, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;
            //Координаты точек основания
            var mainPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z);
            //Координата вершины
            var topPoint = new Vector3(start.X, start.Y, start.Z + height);
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            //Отрисовываем основание по координатам
            foreach (var point in mainPoints) GL.Vertex3(point);
            GL.End();
            //Отрисовываем все стороны пирамиды
            for (var i = 0; i < mainPoints.Length; i++)
            {
                GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Triangles);
                GL.Color4(clr[colorIndex++ % clr.Length]);
                GL.Vertex3(topPoint);
                GL.Vertex3(mainPoints[i]);
                GL.Vertex3(mainPoints[(i + 1) % mainPoints.Length]);
                GL.End();
            }
        }

        /**
         * Метод позволяет получить координаты вершин правильного многоугольника
         */
        private static Vector3[] GetVectorsPolygon(int countAngles, float radius, float posX, float posY, float posZ)
        {
            var vectors = new Vector3[countAngles];
            var angle = Math.PI * 2 / countAngles;
            for (var i = 0; i < countAngles; i++)
            {
                var x = (float)(posX + Math.Cos(angle * i) * radius);
                var y = (float)(posY + Math.Sin(angle * i) * radius);
                vectors[i] = new Vector3(x + posX, y + posY, posZ);
            }

            return vectors;
        }

        public static void DrawConus(Vector3 start, float radius, float height, Color[] clr,
            bool drawLines)
        {
            //Рисуем пирамиду, но с большим числом сторон у основания
            DrawPolygonPyramid(start, radius, 64, height, clr, drawLines);
        }

        public static void DrawCylinder(Vector3 start, float radius, int countAngles, float height, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;

            //Координаты верхнего основания
            var topPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z);
            //Координаты нижнего основания
            var bottomPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z + height);

            //рисуем грани
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            for (var i = 0; i < topPoints.Length; i++)
            {
                GL.Color4(clr[colorIndex++ % clr.Length]);
                //Рисуем в порядке: первая нижняя точка, первая верхняя точка, вторая верхняя точка, вторая нижняя точка
                //Это позволяет получить хорошую сетку и при рисовнии граней и при рисовании сетки
                GL.Vertex3(bottomPoints[i]);
                GL.Vertex3(topPoints[i]);
                GL.Vertex3(topPoints[(i + 1) % topPoints.Length]);
                GL.Vertex3(bottomPoints[(i + 1) % bottomPoints.Length]);
            }

            GL.End();

            //рисуем верхнее основание
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in topPoints) GL.Vertex3(point);
            GL.End();
            //Рисуем нижнее основание
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in bottomPoints) GL.Vertex3(point);
            GL.End();
        }

        /**
         * Рисует сферу
         * stackCount = количество делений по широте(количество широт)
         * sectorCount = количество делений по долготе(количество долгот)
         */
        public static void DrawSphere(Vector3 start, float radius, int stackCount, int sectorCount, Color[] clr,
            bool drawLines)
        {
            var vertexes = new List<Vector3>();
            //Выясняем значение шага в углах
            var sectorStep = 2 * Math.PI / sectorCount;
            var stackStep = Math.PI / stackCount;
            double sectorAngle, stackAngle;
            //Создаем массив вершин
            for (var i = 0; i <= stackCount; i++)
            {
                stackAngle = Math.PI / 2 - i * stackStep;
                var z = radius * Math.Sin(stackAngle) + start.Z;
                //Находим все вершины на широте
                for (var j = 0; j <= sectorCount; j++)
                {
                    sectorAngle = j * sectorStep;
                    //Вычисляем координаты по формуле
                    var x = radius * Math.Cos(stackAngle) * Math.Cos(sectorAngle) + start.X;
                    var y = radius * Math.Cos(stackAngle) * Math.Sin(sectorAngle) + start.Y;
                    vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                }
            }

            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var colorIndex = 0;
            //Рисуем сферу по квадратам
            for (var i = 0; i < vertexes.Count; i++)
            {
                GL.Color4(clr[colorIndex++ % clr.Length]);
                //Первая вершина, следующая вершина по широте, следующая вершина по долготе, и вершина над первой
                GL.Vertex3(vertexes[i]);
                GL.Vertex3(vertexes[(i + 1) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 2 + sectorCount) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 1 + sectorCount) % vertexes.Count]);
            }

            GL.End();
        }

        /**
         * Рисуем бублик
         * sectorCount количество продольных делений
         * stackCount количество поперечных делений
         * innerRadius Внутреннйи радиус
         * outerRadius Внешний(больший) радиус
         */
        public static void DrawThor(Vector3 start, int stackCount, int sectorCount, float innerRadius,
            float outerRadius, Color[] clr,
            bool drawLines)
        {
            var vertexes = new List<Vector3>();
            //Определяем шаг угла для поперечных и продольных
            var sectorStep = 2 * Math.PI / sectorCount;
            var stackStep = 2 * Math.PI / stackCount;
            double sectorAngle, stackAngle;
            //Радиус сечения бублика(тора)
            var sectionRadius = outerRadius - innerRadius;
            //Радиус бублика находится как средний между внешним и внутренним
            var commonRadius = (outerRadius + innerRadius) / 2;

            //Создаем массив вершин
            for (var i = 0; i <= stackCount; i++)
            {
                stackAngle = Math.PI / 2 - i * stackStep;

                for (var j = 0; j <= sectorCount; j++)
                {
                    sectorAngle = j * sectorStep;
                    //Находим координаты, опираясь на формулу функции тора 
                    var z = sectionRadius * Math.Sin(sectorAngle) + start.Z;
                    var x = Math.Cos(stackAngle) * (Math.Cos(sectorAngle) * sectionRadius + commonRadius) + start.X;
                    var y = Math.Sin(stackAngle) * (Math.Cos(sectorAngle) * sectionRadius + commonRadius) + start.Y;

                    vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                }
            }

            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var colorIndex = 0;
            //Рисуем квадратами тор
            for (var i = 0; i < vertexes.Count; i++)
            {
                GL.Color4(clr[colorIndex++ % clr.Length]);
                GL.Vertex3(vertexes[i]);
                GL.Vertex3(vertexes[(i + 1) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 2 + sectorCount) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 1 + sectorCount) % vertexes.Count]);
            }

            GL.End();
        }

        /**
         * Рисуем спираль.
         * sectorCount количество продольных делений
         * stackCount количество поперечных делений
         * innerRadius Внутреннйи радиус
         * outerRadius Внешний(больший) радиус
         * spinsCount Количество вращений
         */
        public static void DrawSpiral(Vector3 start, int stackCount, int sectorCount, float innerRadius,
            float outerRadius, int spinsCount, Color[] clr,
            bool drawLines)
        {
            var vertexes = new List<Vector3>();
            var sectorStep = 2 * Math.PI / sectorCount;
            var stackStep = 2 * Math.PI / stackCount;

            //Радиус сечения бублика(тора) который лежит в основе спирали
            var sectionRadius = outerRadius - innerRadius;
            //Радиус бублика находится как средний между внешним и внутренним
            var commonRadius = (outerRadius + innerRadius) / 2;

            double sectorAngle, stackAngle;
            //Текущее количество вращений
            var currentSpinsCount = 0;
            //Создаем массив вершин
            for (var spineIndex = 1; spineIndex <= spinsCount; spineIndex++)
            for (var i = 0; i <= stackCount; i++)
            {
                stackAngle = Math.PI / 2 - i * stackStep;
                //Пропускаем массив, если рисуем первое сечение не первого вращения
                if (i == 0 && spineIndex != 1) continue;
                currentSpinsCount++;

                var spinOffset = 50f / stackCount;
                for (var j = 0; j <= sectorCount; j++)
                {
                    sectorAngle = j * sectorStep;
                    //Спираль рисуется точно так же как тор, только каждое поперечное сечение чуть выше предыдещего
                    var z = sectionRadius * Math.Sin(sectorAngle) + spinOffset * currentSpinsCount;

                    var x = Math.Cos(stackAngle) * (Math.Cos(sectorAngle) * sectionRadius + commonRadius) + start.X;
                    var y = Math.Sin(stackAngle) * (Math.Cos(sectorAngle) * sectionRadius + commonRadius) + start.Y;
                    vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                }
            }


            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var colorIndex = 0;
            //Рисуем квадратами спиарль
            for (var i = 0; i < vertexes.Count; i++)
            {
                if (i + 3 > vertexes.Count - sectorCount) break;
                GL.Color4(clr[colorIndex++ % clr.Length]);
                GL.Vertex3(vertexes[i]);
                GL.Vertex3(vertexes[(i + 1) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 2 + sectorCount) % vertexes.Count]);
                GL.Vertex3(vertexes[(i + 1 + sectorCount) % vertexes.Count]);
            }

            GL.End();
        }
    }
}