@import url(https://fonts.googleapis.com/css?family=Titillium+Web:400,200,300,600,700);
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline; }

article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block; }

body {
  line-height: 1; }

ol, ul {
  list-style: none; }

blockquote, q {
  quotes: none; }

blockquote:before, blockquote:after,
q:before, q:after {
  content: '';
  content: none; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

.cf:before,
.cf:after {
  content: " ";
  /* 1 */
  display: table;
  /* 2 */ }

.cf:after {
  clear: both;
  display: block; }

.cf {
  /* For IE 6/7 only. Include this rule to trigger hasLayout and contain floats. */
  *zoom: 1; }

* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

body {
  margin: 0;
  padding: 0;
  font-size: 62.5%; }

h1 {
  font: 200 3em/8em "Titillium";
  color: #778096;
  text-align: center; }

.landing {
  position: relative;
  background: url("../images/bg.jpg") center center/1400px no-repeat;
  background: radial-gradient(circle farthest-corner at right bottom, #be222b 0, #873c5a 60%, #1970b7 100%);
  background: radial-gradient(circle farthest-corner at right bottom, #be222b 0, #873c5a 60%, #681d3b 100%); }

.landing--toggle {
  -webkit-animation: toggleBackground 2s infinite;
  -webkit-transition: background 0.2s; }

@-webkit-keyframes toggleBackground {
  0% {
    background: radial-gradient(circle farthest-corner at right bottom, #be222b 0, #873c5a 60%, #681d3b 100%); }

  50% {
    background: radial-gradient(circle farthest-corner at right bottom, #681d3b 0, #873c5a 60%, #1970b9 100%); } }

.landing__header {
  border-bottom: 1px solid rgba(255, 255, 255, 0.06125); }

.landing__nav {
  max-width: 120em;
  margin: 0 auto; }

.landing__nav__logo {
  height: 46px;
  margin: 20px 0;
  display: inline-block;
  float: left; }

.landing__links {
  display: block;
  list-style: none; }

.landing__link {
  display: block;
  list-style: none;
  float: right; }

.landing__href {
  display: block;
  font: 600 1.2em "Titillium";
  color: #b1bed2;
  color: rgba(255, 255, 255, 0.75);
  text-transform: uppercase;
  padding: 3em;
  -webkit-transition: background 0.2s;
  text-decoration: none; }
  .landing__href:hover {
    background: rgba(248, 250, 252, 0.1);
    cursor: pointer; }

.landing__theme {
  font: 200 3.6em "Titillium Web";
  color: white;
  text-align: center; }

.footer__theme {
  font: 200 2.6em "Titillium Web";
  color: #646e74;
  text-align: center; }

.landing__theme__noun__switcher {
  position: relative;
  overflow: hidden;
  -webkit-transition: width 0.2s;
  margin: 0;
  height: 98px; }

.landing__theme__nouns {
  display: block;
  list-style: none;
  list-style-type: none;
  margin: 0;
  padding: 0;
  position: relative;
  -webkit-transform: translateY(0);
  -webkit-transition: -webkit-transform 0.2s; }

.landing__theme__noun {
  display: block;
  margin: 0;
  padding: 0;
  text-align: center;
  font: 700 8em/1.2em "Titillium Web";
  color: white;
  text-transform: uppercase; }

.landing__theme__noun__container {
  display: inline-block; }

.landing__center {
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -ms-flex-align: center;
  -webkit-align-items: center;
  -webkit-box-align: center;
  max-width: 120em;
  margin: 0 auto; }

.landing__container {
  margin: 0 auto;
  width: 100%; }

.landing__supporting {
  margin: 0;
  width: 100%;
  text-align: center;
  font: 300 1.6em "Titillium Web";
  color: rgba(255, 255, 255, 0.75);
  text-transform: uppercase;
  letter-spacing: 1px; }

.landing__image {
  display: block;
  margin: 0 auto;
  margin-top: 1.4em; }

.landing__title {
  font: 400 2.4em "Titillium Web";
  text-transform: uppercase;
  color: #28303c;
  color: white;
  text-align: center;
  display: block;
  margin: 2em auto;
  margin-bottom: 2em;
  width: intrinsic; }

.landing__details {
  font: 200 2em "Titillium Web";
  text-align: center;
  color: #6e7682; }

#map {
  height: 20em; }

.landing__action {
  display: block;
  margin: 0 auto;
  max-width: 20em;
  margin-top: 3em;
  margin-bottom: 0;
  text-align: center;
  color: #b32835;
  background: white;
  border-radius: 2px;
  font: 600 1.6em "Titillium Web";
  padding: 0.75em 0.5em;
  opacity: 0.75;
  -webkit-transition: opacity 0.2s; }
  .landing__action:hover {
    opacity: 1;
    cursor: pointer; }

.landing__foot {
  background: white;
  height: 6em;
  border: 1px solid red; }

#buttoncircuit {
  margin: 0 auto;
  display: block;
  margin-top: 1.4em; }