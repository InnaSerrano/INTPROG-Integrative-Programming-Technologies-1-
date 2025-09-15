// Show/Hide Feedback Form
const feedbackButton = document.querySelector('.feedback-button');
const feedbackFormContainer = document.querySelector('.feedback-form-container');

feedbackButton.addEventListener('click', function() {
  feedbackFormContainer.classList.toggle('visible');
});


const heartMenus = document.querySelectorAll('.heart-menu');

heartMenus.forEach(menu => {
  menu.addEventListener('click', function(e) {
    e.stopPropagation(); 
    heartMenus.forEach(m => {
      if (m !== menu) m.classList.remove('open');
    });
    menu.classList.toggle('open');
  });
});


document.addEventListener('click', function() {
  heartMenus.forEach(menu => menu.classList.remove('open'));
});


const backToTop = document.getElementById('backToTop');

backToTop.addEventListener('click', function() {
  window.scrollTo({ top: 0, behavior: 'smooth' });
});


const faders = document.querySelectorAll('.fade-in');

const appearOptions = {
  threshold: 0.2,
  rootMargin: "0px 0px -50px 0px"
};

const appearOnScroll = new IntersectionObserver(function(entries, appearOnScroll) {
  entries.forEach(entry => {
    if (!entry.isIntersecting) return;
    entry.target.classList.add('visible');
    appearOnScroll.unobserve(entry.target);
  });
}, appearOptions);

faders.forEach(fader => {
  appearOnScroll.observe(fader);
});


const logo = document.querySelector('.logo');
const profileSections = document.querySelectorAll('.profile-section');
const navLinks = document.querySelectorAll('.nav-links a');

logo.addEventListener('click', function(e) {
  e.preventDefault();
  profileSections.forEach(section => section.style.display = 'block');
  navLinks.forEach(link => link.classList.remove('active'));
});
