
async function loadProducts() {
    const products0 = await fetch("https://localhost:7142/api/Product")
    .then(res => res.json());

    return products0;
}

function buildCard(product){
    const card = document.createElement("div");
    card.classList.add("grid-item");

    const img = document.createElement("img");
    img.src = '../images/magassag.jpg'
    img.alt = product.name;

    const name = document.createElement("p");
    name.textContent = product.name;

    const price = document.createElement("p");
    price.textContent = `${product.price} Ft`;

    const sex = document.createElement("p");
    sex.innerHTML=`${product.sex}`
    const valami = document.createElement("p");
    valami.innerHTML ="wsswswsw"
    card.append(img,price ,name , sex);

    card.addEventListener('click',() => {
        window.location.href = `product_view.html?id=${product.id}`;})
        return card
}


async function fill_grid(prods){
    const grid = document.getElementById("img_grid");
    console.log(grid)
    let count = 0
    prods.forEach(element => {
        const card = buildCard(element)
        grid.appendChild(card)
        count++
    });
    console.log(count +" products")
}
async function init(){
    let products = await loadProducts()
    console.log(products)
    //fill_ul(products);
    fill_grid(products);
}

init()
