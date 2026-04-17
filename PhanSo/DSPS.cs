using Bai2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_2
{
    public class DSPS
    {
        private PhanSo[] _dsPS;
        private int _size;

        public PhanSo[] DsPS { get => _dsPS; set => _dsPS = value; }
        public int Size { get => _size; set => _size = value; }

        public DSPS()
        {
            _size = 0;
            _dsPS = new PhanSo[_size];
        }
        public void NhapPS()
        {
            Console.WriteLine("Nhap so luong phan tu ");
            _size = int.Parse(Console.ReadLine());
            _dsPS = new PhanSo[_size];
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}:", i + 1);
                _dsPS[i] = new PhanSo();
                _dsPS[i].Nhap();
            }
        }
        public void XuatPS()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine("Phan so thu {0}:", i + 1);
                _dsPS[i].Xuat();
            }
        }
        public int sosanh(PhanSo a, PhanSo b)
        {
            int tua = a.TuSo * b.MauSo;
            int tub = b.TuSo * a.MauSo;
            if (tua > tub)
                return 1;
            else if (tua < tub)
                return -1;
            else
                return 0;

        }
        public PhanSo Max()
        {
            PhanSo max = _dsPS[0];
            for (int i = 1; i < _size; i++)
            {
                if (sosanh(_dsPS[i], max) == 1)
                {
                    max = _dsPS[i];
                }
            }
            return max;
        }
        public void TangDan()
        {
            for(int i = 0; i < _size-1; i++)
            {
                for(int j = i + 1; j < _size; j++)
                {
                    if(sosanh(_dsPS[i], _dsPS[j]) == 1)
                    {
                       PhanSo temp = _dsPS[i];
                        _dsPS[i] = _dsPS[j];
                        _dsPS[j] = temp;
                    }
                }
            }
        }



}
}
