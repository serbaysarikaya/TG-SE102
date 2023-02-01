// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#q").keyup(function () {
        $("#test").empty();
        let q = $(this).val()
        

        $.get("https://localhost:7049/api/products", function (data, status) {
            data.filter(x => x.title.includes(q)).forEach(x => {
                let card = '<div class="col"><div class="card h-100"><img src="https://picsum.photos/800/450?random" class="card-img-top" alt="...">                        <div class="card-body"><h5 class="card-title">' + x.title + '</h5><p class="card-text">' + x.categoryName + '</p>                            <p class="card-text">' + x.price + ' TL</p><p class="card-text">' + x.description + '</p></div></div></div>'
                $("#test").append(card)

            })
        });
    });
});

