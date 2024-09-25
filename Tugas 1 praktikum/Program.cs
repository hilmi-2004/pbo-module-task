using System;
using System.Collections.Generic;

class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama : {nama}\nUmur : {umur}";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini mengeluarkan suara khas.";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public void Mengaum()
    {
        Console.WriteLine($"{nama} sedang mengaum!");
    }

    public override string Suara()
    {
        return "Aummm!";
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "Brriiuuuu!";
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil ini mengeluarkan suara yang khas.";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) 
    {

    }

    public void Merayap()
    {
        Console.WriteLine($"{nama} sedang merayap!");
    }

    public override string Suara()
    {
        return "Sssss!";
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "Grrawwr!";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine($"Suara: {hewan.Suara()}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa1 = new Singa("Singa Afrika", 5, 4);
        kebunBinatang.TambahHewan(singa1);

        Gajah gajah1 = new Gajah("Gajah Sumatra", 12, 4);
        kebunBinatang.TambahHewan(gajah1);

        Ular ular1 = new Ular("Ular Piton", 3, 6.5);
        kebunBinatang.TambahHewan(ular1);

        Buaya buaya1 = new Buaya("Buaya Muara", 7, 4.2);
        kebunBinatang.TambahHewan(buaya1);

        kebunBinatang.DaftarHewan();

        singa1.Mengaum();
        ular1.Merayap();
    }
}
