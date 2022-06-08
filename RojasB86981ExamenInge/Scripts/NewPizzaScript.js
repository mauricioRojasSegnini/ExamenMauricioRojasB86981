document.addEventListener("click", function () {
    let price = 0;
    price += addSizePrice();
    price += addSaucePrice();
    price += addMassPrice();
    price += addIngredientsPrice();
    price += addExtrasPrice(price);
    if (price == 0) {
        document.getElementById("price").innerHTML = '';
    } else {
        document.getElementById("price").innerHTML = price + ".00 colones";
    }
    document.getElementById("Price").value = price;
});

function addSizePrice() {
    let Size = document.getElementById("Size").value;
    let sizePrice = 0;
    if (Size != "") {
        if (Size == 'Personal') {
            sizePrice = 1000;
        }
        if (Size == 'Mediana') {
            sizePrice = 2000;
        }
        if (Size == 'Familiar') {
            sizePrice = 3000;
        }
    } else {
        sizePrice = 0;
    }
    return sizePrice;
}

function addSaucePrice() {
    let Sauce = document.getElementById("Sauce").value;
    if (Sauce != "") {
        return 1000;
    } else {
        return 0;
    }
}

function addMassPrice() {
    let mass = document.getElementById("Mass").value;
    let massPrice = 0;
    if (mass != "") {
        if (mass == 'Integral') {
            massPrice = 2000;
        }
        if (mass == 'Fina') {
            massPrice = 2000;
        }
        if (mass == 'Gruesa') {
            massPrice = 3000;
        }
        if (mass == 'Estilo Chicago') {
            massPrice = 3500;
        }
    } else {
        massPrice = 0;
    }
    return massPrice;
}

function addIngredientsPrice() {
    var IngredientsCheckted = document.querySelector('.IngredientsSelected:checked');
    if (IngredientsCheckted != null) {
        return 1000;
    }
    else {
        return 0;
    }
}

function addExtrasPrice(price) {
    var ExtrasPiña = ((document.querySelector('.PiñaSelected:checked') == null) ? '' : 'Piña');
    var ExtrasAvocado = ((document.querySelector('.AguacateSelected:checked') == null) ? '' : 'Aguacate');
    var ExtrasCaviar = ((document.querySelector('.CaviarSelected:checked') == null) ? '' : 'Caviar');
    let ExtrasPrice = 0;
    if (ExtrasPiña == 'Piña') {
        ExtrasPrice += 250;
    }
    if (ExtrasAvocado == 'Aguacate') {
        ExtrasPrice += 950;
    }
    if (ExtrasCaviar == 'Caviar') {
        ExtrasPrice += 1000;
    }
    return ExtrasPrice;
}