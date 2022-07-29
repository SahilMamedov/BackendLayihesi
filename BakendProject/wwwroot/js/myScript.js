
const subscribe = document.querySelector(".subscribe")

const subscribeBtn = document.querySelector(".subscribe-btn")


const handleSetEmail = (ev) => {
    ev.preventDefault();
    var formData = new FormData();

    formData.append("Email", subscribe.value)
    console.log(formData)
    axios.post("/home/subscribe", formData).then(() => { alert("nices") }).catch(() => { alert("error") })


}

subscribeBtn.addEventListener("click", handleSetEmail)



///-----------------------------------------///\
const sortRow = document.getElementById("sort")
const sortRowPage2 = document.getElementById("list")
async function  myFunction()  {
    var value = document.getElementById("mySelect").value
  
    const { data} = await axios.get("/shop/Sort?take=" + value)
   // const  dataPageTwo  = await axios.get("/shop/SortTwoPage?take=" + value)
/*     sortRowPage2.innerHTML = dataPageTwo.data*/
     sortRow.innerHTML = data
}


async function SortMinMax() {
    const minMax = document.getElementById("sortMinMax").value
    const { data } = await axios.get("/shop/SortMinMax?min=" + minMax)
 //  const dataPageTwo = await axios.get("/shop/SortMinMaxPageTwo?min=" + minMax)
 
    sortRow.innerHTML = data
/*    sortrowpage2.innerhtml = dataPageTwo.data*/
    

}


const btnSubProduct = document.querySelectorAll(".subBtnProduct")

const detailContent = document.querySelector(".detail-content")

    btnSubProduct.forEach(item => {

        const handleShowDetail = async () => {
           
            const dataIdBtnSub = item.getAttribute("data-id")

            const { data} = await axios.get("/shop/detailtwo?id=" + dataIdBtnSub)
            
            detailContent.innerHTML = data

        }

        item.addEventListener("click", handleShowDetail)

    })
const tabContent = document.querySelector(".tab-content")
btnSubProduct.forEach(item => {

    const handleShowDetail = async () => {

        const dataIdBtnSub = item.getAttribute("data-id")

        const { data } = await axios.get("/shop/DescComment?id=" + dataIdBtnSub)
        console.log(data)
        tabContent.innerHTML = data
    }

    item.addEventListener("click", handleShowDetail)
})

//--------------basket--------------///


const basketItem = document.querySelectorAll(".basketItem")
const newUl = document.querySelector(".newUl");
const count = document.querySelector(".count");
const totalProduct = document.querySelector(".total");
const arr = [];
basketItem.forEach(btn => {

    const handleAddItemToBasket = async (ev) =>
    {

        ev.preventDefault();
        const dataIdProduct = btn.getAttribute("data-id")
        
        const { data } = await axios.get("/basket/additem?id=" + dataIdProduct)
        const div = `
        
                                             <li>
                                                <div class="single-cart-item d-flex">
                                                    <div class="cart-item-thumb">
                                                        <a href="single-product.html"><img src="/images/${data.imgUrl}" alt="product"></a>
                                                        <span class="product-quantity">${data.productCount}</span>
                                                    </div>
                                                    <div class="cart-item-content media-body">
                                                        <h5 class="product-name"><a href="single-product.html">${data.name}</a></h5>
                                                        <span class="product-price">€${data.price}</span>
                                                        <span class="product-color"><strong>Color:</strong> White</span>
                                                        <a href="#" class="product-close"><i class="fal fa-times"></i></a>
                                                    </div>
                                                </div>             
                                             </li>

`
        totalProduct.innerHTML = "$" + data.total
       
        if (Object.keys(data).length !== 0) {
            var newDoc = new DOMParser().parseFromString(div, "text/html");
            count.innerHTML = data.count
            newUl.append(newDoc.firstChild.lastChild.firstChild)
        }
           
        }
      

    btn.addEventListener("click",handleAddItemToBasket)
})

const countProduct = document.querySelectorAll(".countProduct")
const plusBtn = document.querySelectorAll(".plusBtn")
const sum = document.querySelectorAll(".total-amount");
const minusBtn = document.querySelectorAll(".minusBtn");
const removeBtn = document.querySelectorAll(".removeBtn");

removeBtn.forEach(item => {
    let total = 0;
    let myCount = 0;
    async function handleRemoveElement(ev) {
        ev.preventDefault();
        const removeId = item.getAttribute("data-id")
        try {
            const { data } = await axios.get("/basket/remove?id=" + removeId)
            this.parentElement.parentElement.parentElement.remove();
            data.forEach(item => {
              
                total += item.sum
                myCount = item.count
            })
            count.innerHTML = myCount
            totalProduct.innerHTML = "$" + total
        } catch (err) {
            alert(err)
        }
       
    }

    item.addEventListener("click",handleRemoveElement)
})

minusBtn.forEach(item => {
   

    const dataIdProduct = item.getAttribute("data-id")

    item.addEventListener("click", async () => {
        const { data } = await axios.get("/basket/minus?id=" + dataIdProduct)
        let total = 0;
        countProduct.forEach(value => {
            const productId = value.getAttribute("data-id")

            if (productId == dataIdProduct) {

                
                data.forEach(item => {

                    if (item.isExistCount >= 1) {
                        value.value = item.isExistCount

                  
                        total += item.sum
                        sum.forEach(s => {
                            const sumId = s.getAttribute("data-id")

                            if (sumId == dataIdProduct) {
                                s.innerHTML = "€" + item.isExistSum
                            }
                           
                            totalProduct.innerHTML = "$" + total
                        })

                    } 

                })
       
            }


        })

       

    })


})

plusBtn.forEach(item => {
  
    const dataIdProduct = item.getAttribute("data-id")
    item.addEventListener("click", async () => {
        let total = 0
        const { data } = await axios.get("/basket/plus?id=" + dataIdProduct)

        
        countProduct.forEach(value => {
            const productId = value.getAttribute("data-id")
            if (productId == dataIdProduct) {

                data.forEach(item => {
                    
                    if (item.isExistCount <= item.productCount) {
                        value.value = item.isExistCount
                        total += item.sum
                        sum.forEach(s => {
                            const sumId = s.getAttribute("data-id")
                         
                            if (sumId == dataIdProduct) {
                                s.innerHTML = "€" + item.isExistSum
                            }
                            totalProduct.innerHTML = "$" + total
                        })

                    } else {
                        alert("olmaz")
                    }

                })


            }

            })

       


    })
})


///-------------------------------------////

