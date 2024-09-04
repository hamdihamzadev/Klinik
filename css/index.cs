/* Reset */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

/*
css / 
 - index.css 
 - index.css.map
 - index.scss
 - 

*


/* Variables */
body {
  font-family: "Roboto", sans-serif;
  line-height: 1.6;
  overflow-x: hidden;
}

p {
  padding: 0px;
  margin: 0px;
}

h1,
h2,
h3,
h4,
h5,
h6,
p {
  width: fit-content;
}

svg {
  color: #0463FA;
}

button {
  background-color: #0463FA;
  color: #eff5ff;
}

small {
  color: #8D8E92;
}

a {
  text-decoration: none;
}

.activelink {
  color: #0463FA;
}

#Breadcrumb {
  height: 37%;
  background-image: url(/img/header-page.jpg);
  background-size: cover;
  background-position: center;
}

#slide,
#About-Us,
section#Services,
#Features,
#Doctors,
#testimonial,
#Appointment,
#Breadcrumb,
#contact {
  margin-bottom: 150px;
}

#topBar {
  background-color: #eff5ff;
}
#topBar #icon-topbar {
  margin-right: 6px;
}
#topBar #social-media a {
  background-color: white;
  height: 30px;
  width: 30px;
  transition: background-color 0.3s ease;
}
#topBar #social-media a:hover {
  background-color: #0463FA;
}
#topBar #social-media a:hover i {
  color: white;
}
#topBar #social-media i {
  color: #0463FA;
  transition: color 0.3s ease;
}

#navbar #navbarText {
  margin-right: 200px;
}
#navbar #btn-nav {
  background-color: #0463FA;
  color: #eff5ff;
  width: 200px;
  border-radius: 0px;
}
#navbar #btn-nav svg {
  color: #eff5ff;
  margin-left: 5px;
}

#text-slide {
  background-color: #0463FA;
}
#text-slide #title-text {
  font-weight: 900;
  color: #eff5ff;
}

#navbar #navbarText ul li a #arrow-bottom {
  color: rgb(0, 0, 0);
}
#navbar #navbarText ul li a:hover {
  color: #0463FA;
}
#navbar #navbarText ul li a:hover #arrow-bottom {
  color: #0463FA;
}
#navbar #navbarText ul li #list-pages {
  width: 132px;
  margin-top: 30px;
  opacity: 0;
  transition: transform 0.7s ease;
}
#navbar #navbarText ul li #list-pages li a {
  color: #0463FA;
}
#navbar #navbarText ul li #list-pages li:hover {
  background-color: #0463FA;
}
#navbar #navbarText ul li #list-pages li:hover a {
  color: white;
}
#navbar #navbarText ul li:hover #list-pages {
  opacity: 1;
  transform: translateY(-16px);
}

#About-Us #text #name-section {
  color: #8D8E92;
}
#About-Us #text #title-section {
  color: #1B2C51;
  font-weight: 600;
}
#About-Us #text #para,
#About-Us #text #advantage {
  color: #8D8E92;
}
#About-Us #text #btn-Read {
  background-color: #0463FA;
}
#About-Us #section-img #img-about-2 {
  margin-top: -25%;
}

#Services #name-section {
  color: #8D8E92;
}
#Services #title-section {
  font-weight: 600;
  color: #1B2C51;
}
#Services #bg-service {
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  background-color: #eff5ff;
}
#Services #bg-service #container-icon {
  height: 65px;
  width: 65px;
}
#Services #bg-service #name-service {
  color: #1B2C51;
}
#Services #bg-service #para {
  color: #8D8E92;
}
#Services #bg-service #btn {
  width: max-content;
  height: 40px;
  transition: 0.5s;
}
#Services #bg-service #btn span {
  display: none;
  transition: 0.5s;
}
#Services #bg-service:hover #btn span {
  display: block;
}
#Services #bg-service:hover #btn #icon {
  margin-right: 8px;
  transition: 0.5s;
}
#Services #bg-service:hover {
  transform: scale(1.03);
  box-shadow: 2px 0px 20px rgba(0, 0, 0, 0.1);
}

#Features {
  background-color: #0463FA;
}
#Features #icon {
  height: 50px;
  width: 50px;
}
#Features #img-features {
  height: -webkit-fill-available;
}

#Doctors #name-section {
  color: #8D8E92;
}
#Doctors #title-section {
  color: #1B2C51;
}
#Doctors #doctor {
  position: relative;
}
#Doctors #doctor #img-doctor {
  transition: transform 0.5s ease;
}
#Doctors #doctor #informations {
  background-color: #eff5ff;
  height: 100px;
  transition: height 0.5s ease, margin-top 0.5s ease;
}
#Doctors #doctor #informations #Department {
  color: #0463FA;
}
#Doctors #doctor #informations #social-media {
  opacity: 0;
  transition: opacity 0.5s ease;
}
#Doctors #doctor #informations #social-media #link {
  height: 40px;
  width: 40px;
  background-color: white;
  transition: background-color 0.3s ease;
}
#Doctors #doctor #informations #social-media #link i {
  color: #0463FA;
}
#Doctors #doctor #informations #social-media #link:hover {
  background-color: #0463FA;
}
#Doctors #doctor #informations #social-media #link:hover i {
  color: white;
}
#Doctors #doctor:hover #img-doctor {
  transform: translateY(-20px);
}
#Doctors #doctor:hover #informations #social-media {
  opacity: 1;
}
#Doctors #doctor:hover #informations {
  height: 160px;
  margin-top: -60px;
}
#Doctors #icon {
  height: 20px;
  width: 20px;
}
#Doctors #icon #icon-socialmedia {
  color: #0463FA;
}

#Appointment #name-section {
  color: #8D8E92;
}
#Appointment #title-section {
  color: #1B2C51;
}
#Appointment #para {
  color: #8D8E92;
}
#Appointment #phone,
#Appointment #email {
  background-color: #eff5ff;
}
#Appointment #phone #title-contact,
#Appointment #email #title-contact {
  color: #8D8E92;
}
#Appointment #container-form {
  background-color: #eff5ff;
}

#testimonial #header-testimonial #name-section {
  color: #8D8E92;
}
#testimonial #header-testimonial #title-section {
  color: #1B2C51;
}

#Footer {
  background-color: #1B2C51;
  color: white;
}
#Footer a {
  color: white;
  width: max-content;
}
#Footer #Address #social-media a {
  border: 1px solid white;
  transition: border-color 0.3s ease, color 0.3s ease;
}
#Footer #Address #social-media a:hover {
  color: #0463FA;
  border-color: #0463FA;
}
#Footer #Services #Services-links a,
#Footer #Quick-Links #links a {
  display: inline-block;
  transition: transform 0.3s ease;
}
#Footer #Services #Services-links a:hover #icon-arrow,
#Footer #Quick-Links #links a:hover #icon-arrow {
  transform: scaleX(1);
}
#Footer #Services #Services-links a:hover,
#Footer #Quick-Links #links a:hover {
  color: #0463FA;
  transform: scaleX(1.1);
}
#Footer #btn-signup {
  transform: translate(-16px, -50%);
}

#contact #name-section {
  color: #8D8E92;
}
#contact #title-section {
  color: #1B2C51;
}
#contact #para {
  color: #8D8E92;
}
#contact #phone,
#contact #location,
#contact #email {
  background-color: #eff5ff;
}
#contact #container-form {
  background-color: #eff5ff;
}

@media (min-width: 576px) {
  /* Slide start */
  #slide #text-slide #title-text {
    font-size: 24px;
  }
}

/*# sourceMappingURL=index.cs.map */
