const backToTop = document.getElementById('backToTop');

window.addEventListener('scroll', () => {
  if (window.scrollY > 300) {
    backToTop.classList.add('visible');
  } else {
    backToTop.classList.remove('visible');
  }
});

backToTop.addEventListener('click', () => {
  window.scrollTo({ top: 0, behavior: 'smooth' });
});


const faders = document.querySelectorAll('.fade-in');

const appearOptions = {
  threshold: 0.2,
  rootMargin: "0px 0px -50px 0px"
};

const appearOnScroll = new IntersectionObserver((entries, observer) => {
  entries.forEach(entry => {
    if (!entry.isIntersecting) return;
    entry.target.classList.add('visible');
    observer.unobserve(entry.target);
  });
}, appearOptions);

faders.forEach(fader => {
  appearOnScroll.observe(fader);
});

// Heart Menu Toggle
const heartMenus = document.querySelectorAll('.heart-menu');

heartMenus.forEach(menu => {
  menu.addEventListener('click', () => {
    
    heartMenus.forEach(m => {
      if (m !== menu) m.classList.remove('open');
    });
    menu.classList.toggle('open');
  });
});


document.addEventListener('click', e => {
  heartMenus.forEach(menu => {
    if (!menu.contains(e.target)) {
      menu.classList.remove('open');
    }
  });
});


const typingElement = document.querySelector(".typing");

if (typingElement) {
  const text = typingElement.textContent;
  typingElement.textContent = "";
  let i = 0;

  function typeWriter() {
    if (i < text.length) {
      typingElement.textContent += text.charAt(i);
      i++;
      setTimeout(typeWriter, 100);
    }
  }

  typeWriter();
}
