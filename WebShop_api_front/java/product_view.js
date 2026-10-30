// 1. Fetch the product from the API
async function loadProduct() {
    const urlParams = new URLSearchParams(window.location.search);
    const productId = urlParams.get('id');
    
    console.log(productId + " is the parameter");

    //if (!productId) {
    //    console.error("No product ID found in URL!");
    //    return null;
    //}

    //try {
        const response = await fetch(`https://localhost:7142/api/Product/${productId}`);
        //if (!response.ok) {
        //    throw new Error(`HTTP error! status: ${response.status}`);
        //}
        const product = await response.json();
        return product;
    //} catch (error) {
    //    console.error("Fetch failed:", error);
    //    return null;
    //}
}

// 2. Render the details to the DOM
function renderProductDetails(product) {
    if (!product) return;

    document.getElementById("product-name").textContent = product.name;
    document.getElementById("product-price").textContent = `${product.price} Ft`;
    // ... populate other fields
}

// 3. Kick off the execution flow
async function init() {
    const product = await loadProduct(); // This waits for the fetch to complete    
    //if (product) {
        renderProductDetails(product); // Now the backend will definitely be hit, and data will exist
   // }
}

init();