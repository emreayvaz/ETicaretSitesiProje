    var fotografNumara = 0;                                     //fotoğraf no
    var fotograflar = document.querySelectorAll("UL LI IMG")    //fotoğraflar dizisi
    var buton = document.querySelectorAll("center div i");      //buton dizisi
    document.getElementById("fotoNum").innerHTML = "Fotoğraf: " + (fotografNumara + 1) + "/" + fotograflar.length;
    document.getElementById("fotoAciklama").innerHTML = fotograflar[fotografNumara].alt;
    //önceki fotoğraf
    buton[0].addEventListener('click', function () {
        if (fotografNumara > 0) {
        fotografNumara -= 1;
    document.getElementById("fotoNum").innerHTML = "Fotoğraf: " + (fotografNumara + 1) + "/" + fotograflar.length;
    document.getElementById("imgBig").src = fotograflar[fotografNumara].src;
    document.getElementById("imgBig").alt = fotograflar[fotografNumara].alt;
    document.getElementById("fotoAciklama").innerHTML = fotograflar[fotografNumara].alt;
        } else if (fotografNumara == 0) {               //başa sarma
        fotografNumara = fotograflar.length - 1;
    document.getElementById("fotoNum").innerHTML = "Fotoğraf: " + (fotografNumara + 1) + "/" + fotograflar.length;
    document.getElementById("imgBig").src = fotograflar[fotografNumara].src;
    document.getElementById("imgBig").alt = fotograflar[fotografNumara].alt;
    document.getElementById("fotoAciklama").innerHTML = fotograflar[fotografNumara].alt;
        }
    })

    //sonraki fotoğraf
    buton[1].addEventListener('click', function () {
        if (fotografNumara < fotograflar.length - 1) {
        fotografNumara += 1;
    document.getElementById("fotoNum").innerHTML = "Fotoğraf: " + (fotografNumara + 1) + "/" + fotograflar.length;
    document.getElementById("imgBig").src = fotograflar[fotografNumara].src;
    document.getElementById("imgBig").alt = fotograflar[fotografNumara].alt;
    document.getElementById("fotoAciklama").innerHTML = fotograflar[fotografNumara].alt;
        } else if (fotografNumara == 4) {               //başa sarma
        fotografNumara = 0;
    document.getElementById("fotoNum").innerHTML = "Fotoğraf: " + (fotografNumara + 1) + "/" + fotograflar.length;
    document.getElementById("imgBig").src = fotograflar[fotografNumara].src;
    document.getElementById("imgBig").alt = fotograflar[fotografNumara].alt;
    document.getElementById("fotoAciklama").innerHTML = fotograflar[fotografNumara].alt;
        }
    })