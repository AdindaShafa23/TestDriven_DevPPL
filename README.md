# TDD Exercises (C# + NUnit)

Proyek ini menyiapkan *template* latihan TDD untuk tiga soal:
1) `IsPrime(int n)`
2) `CalculateDiscount(total, isMember)`
3) `FizzBuzz(int n)`

## Cara Menjalankan
Pastikan .NET SDK 8.0 sudah terpasang.

```bash
# dari folder root proyek
dotnet restore
dotnet test -v minimal
```

> Struktur proyek:
```
AppLib/        -> kode produksi
Tests/         -> unit test NUnit
```

## Catatan TDD (Ringkas)

### Soal 1 – IsPrime
- **RED**: Tambahkan test untuk 2→true, 4→false, 7→true. Semua gagal karena implementasi belum ada.
- **GREEN**: Implementasi sederhana `for (i=2..n-1)` agar lulus.
- **REFACTOR**: Optimasi batas perulangan `i <= sqrt(n)`, skip bilangan genap.
- **Tambahan Test**: 1→false, 13→true, 15→false, juga 0 & negatif → false. Semua tetap lulus.

### Soal 2 – CalculateDiscount
- **Aturan**: 
  - total > 100000 && member → diskon 10%
  - total > 100000 && non-member → diskon 5%
  - total ≤ 100000 → diskon 0
  - total < 0 → `ArgumentException`
- **RED**: Tulis seluruh skenario (termasuk exception).
- **GREEN**: Implementasi minimal.
- **REFACTOR**: Rapikan tanpa ubah perilaku.
- **Hasil**: Seluruh test lulus.

### Soal 3 – FizzBuzz
- **RED**: Test untuk 3, 5, 15, 7.
- **GREEN**: Implementasi minimal dengan kombinasi logika.
- **REFACTOR**: Sederhanakan, tetap lulus.

## Tabel Hasil Pengujian (Soal 2)
| No | Input (total, isMember) | Expected Output | Actual Output | Status |
| --- | --- | --- | --- | --- |
| 1 | (120000, true) | 12000 | 12000 | Pass |
| 2 | (120000, false) | 6000 | 6000 | Pass |
| 3 | (50000, true) | 0 | 0 | Pass |
| 4 | (-1000, true) | Exception | Exception | Pass |

