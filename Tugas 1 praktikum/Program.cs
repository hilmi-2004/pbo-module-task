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
        return $"Nama : {nama}\nUmur : {umur} tahun";
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
        return "Mamalia ini bersuara";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"\nJumlah kaki: {jumlahKaki}";
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
        return "Reptil ini bersuara.";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"\nPanjang tubuh: {panjangTubuh} meter";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "Singa Ini Bersuara Aummm!";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{nama} sedang mengaum: Aummmmmmmmmmmmmmmmmmm!");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "Gajah Ini Bersuara Prottttt!";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }


    public override string Suara()
    {
        return "Ular Ini Bersuara Ssssssssssssssssssssssss!";
    }

    public void Merayap()
    {
        Console.WriteLine($"{nama} sedang merayap!");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "Buaya Ini Bersuara Grrawwwwwwwwrrrrrrrr!";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"{hewan.nama} telah ditambahkan ke kebun binatang.");
    }

    public void DaftarHewan()
    {
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine($"Suara: {hewan.Suara()}\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();
        Singa singa1 = new Singa("Singa Amerika", 5, 4);
        Gajah gajah1 = new Gajah("Gajah Sumatera", 12, 4);
        Ular ular1 = new Ular("Ular Python", 3, 6.5);
        Buaya buaya1 = new Buaya("Buaya Muara", 7, 4.2);

        kebunBinatang.TambahHewan(singa1);
        kebunBinatang.TambahHewan(gajah1);
        kebunBinatang.TambahHewan(ular1);
        kebunBinatang.TambahHewan(buaya1);

        kebunBinatang.DaftarHewan();

        Console.WriteLine($"Suara singa: {singa1.Suara()}");
        Console.WriteLine($"Suara gajah: {gajah1.Suara()}");
        Console.WriteLine($"Suara ular: {ular1.Suara()}");
        Console.WriteLine($"Suara buaya: {buaya1.Suara()}");

        singa1.Mengaum();
        ular1.Merayap();
    }
}
