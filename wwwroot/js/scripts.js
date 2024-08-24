document.addEventListener("DOMContentLoaded", () => {
  const slides = document.querySelectorAll(".carousel-slide");
  const nextBtn = document.querySelector(".next");
  const prevBtn = document.querySelector(".prev");
  let index = 0;

  function showSlide(n) {
    if (n >= slides.length) {
      index = 0;
    } else if (n < 0) {
      index = slides.length - 1;
    } else {
      index = n;
    }

    // Mueve el contenedor del carrusel en función del índice
    document.querySelector(".hero-carousel").style.transform = `translateX(-${
      index * 33.33
    }%)`;
  }

  nextBtn.addEventListener("click", () => {
    showSlide(index + 1);
  });

  prevBtn.addEventListener("click", () => {
    showSlide(index - 1);
  });

  showSlide(index); // Inicializa el carrusel en la primera imagen
});
