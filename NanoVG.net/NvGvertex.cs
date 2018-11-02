namespace NanoVGDotNet
{
    public struct NvGvertex
    {
        public float X;
        public float Y;
        public float U;
        public float V;

        public override string ToString()
        {
            return $"[NVGvertex] x={X} y={Y} u={U} v={V}";
        }
    }
}