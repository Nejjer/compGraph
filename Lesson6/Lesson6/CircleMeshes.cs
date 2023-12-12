﻿using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public static class CircleMeshes
    {
        public static void DrawPyramid(Vector3 start, float radius, int countAngles, float lz, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;

            var mainPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z);
            var topPoint = new Vector3(start.X, start.Y, start.Z + lz);
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in mainPoints) GL.Vertex3(point);
            GL.End();


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

        public static void DrawConus(Vector3 start, float radius, float lz, Color[] clr,
            bool drawLines)
        {
            DrawPyramid(start, radius, 64, lz, clr, drawLines);
        }

        public static void DrawCylinder(Vector3 start, float radius, int countAngles, float lz, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;

            var topPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z);
            var bottomPoints = GetVectorsPolygon(countAngles, radius, start.X, start.Y, start.Z + lz);

            //рисуем стороны
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            for (var i = 0; i < topPoints.Length; i++)
            {
                GL.Color4(clr[colorIndex++ % clr.Length]);
                //рисуем по очереди, сначала сверху вниз, потом снизу вверх
                GL.Vertex3(bottomPoints[i]);
                GL.Vertex3(topPoints[i]);
                GL.Vertex3(topPoints[(i + 1) % topPoints.Length]);
                GL.Vertex3(bottomPoints[(i + 1) % bottomPoints.Length]);
            }

            GL.End();
            //рисуем основания
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in topPoints) GL.Vertex3(point);
            GL.End();

            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in bottomPoints) GL.Vertex3(point);
            GL.End();
        }

        public static void DrawSphere(Vector3 start, float radius, int stackCount, int sectorCount, Color[] clr,
            bool drawLines)
        {
            var vertexes = new List<Vector3>();

            var sectorStep = 2 * Math.PI / sectorCount;
            var stackStep = Math.PI / stackCount;
            double sectorAngle, stackAngle;
            //Создаем массив вершин
            for (var i = 0; i <= stackCount; i++)
            {
                stackAngle = Math.PI / 2 - i * stackStep;
                var z = radius * Math.Sin(stackAngle) + start.Z;

                for (var j = 0; j <= sectorCount; j++)
                {
                    sectorAngle = j * sectorStep;

                    var x = radius * Math.Cos(stackAngle) * Math.Cos(sectorAngle) + start.X;
                    var y = radius * Math.Cos(stackAngle) * Math.Sin(sectorAngle) + start.Y;
                    vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                }
            }

            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var colorIndex = 0;
            //Рисуем квадратами сферу
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
        
        public static void DrawThor(Vector3 start, float radius, int stackCount, int sectorCount, Color[] clr,
            bool drawLines)
        {
            // int numc = 16, numt = 16;
            //
            // double TWOPI = 2 * Math.PI;
            // for (int i = 0; i < numc; i++) {
            //     GL.Begin(BeginMode.QuadStrip);
            //     for (int j = 0; j <= numt; j++) {
            //         for (int k = 1; k >= 0; k--) {
            //
            //             double s = (i + k) % numc + 50;
            //             double t = j % numt;
            //
            //             double x = (100 + 10 * Math.Cos(s * TWOPI / numc)) * Math.Cos(t * TWOPI / numt);
            //             double y = (100 + 10 * Math.Cos(s * TWOPI / numc)) * Math.Sin(t * TWOPI / numt);
            //             double z = 10 * Math.Sin(s * TWOPI / numc);
            //
            //             GL.Vertex3(2 * x, 2 * y, 2 * z);
            //         }
            //     }
            //     GL.End();
            // }
            //
            //
            
            
            var vertexes = new List<Vector3>();
            
            var sectorStep = 2 * Math.PI / sectorCount;
            var stackStep = 2 * Math.PI / stackCount;
            double sectorAngle, stackAngle;
            //Создаем массив вершин
            for (var i = 0; i <= stackCount; i++)
            {
                stackAngle = Math.PI / 2 - i * stackStep;
            
                for (var j = 0; j <= sectorCount; j++)
                {
                    sectorAngle = j * sectorStep;
                    var z = 20 * Math.Sin(sectorAngle);
            
                    var x = Math.Cos(stackAngle) * (Math.Cos(sectorAngle) * 20 + radius);
                    var y = Math.Sin(stackAngle) * (Math.Cos(sectorAngle) * 20 + radius);
                    vertexes.Add(new Vector3((float)x, (float)y, (float)z));
                }
            }
            
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var colorIndex = 0;
            //Рисуем квадратами сферу
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
    }
}