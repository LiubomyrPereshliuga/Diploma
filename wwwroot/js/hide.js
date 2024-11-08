const check = document.getElementById('check');

window.onload = function () {
    slideOne();
    slideTwo();
    inputOne();
    inputTwo();
    document.getElementById("range1") = null;
    document.getElementById("range2") = null;
}

function show1() {
	document.getElementById('div1').style.display = 'none';
    check.checked = false;
    document.getElementById('range1').value = null;
    document.getElementById('range2').value = null;
}

function show2() {
	document.getElementById('div1').style.display = 'flex';
}

check.addEventListener('change', () => {
	if (check.checked) {
		document.getElementById('radio1').checked = true;
	}
	else if (document.getElementById('radio1').checked = false) {
		show1();
	}
});



let sliderOne = document.getElementById("slider-1");
let sliderTwo = document.getElementById("slider-2");
let displayValOne = document.getElementById("range1");
let displayValTwo = document.getElementById("range2");
let minGap = 0;
let sliderTrack = document.querySelector(".slider-track");
let sliderMaxValue = document.getElementById("slider-1").max;

function slideOne() {
    if (parseInt(sliderTwo.value) - parseInt(sliderOne.value) <= minGap) {
        sliderOne.value = parseInt(sliderTwo.value) - minGap;
    }
    displayValOne.value = sliderOne.value;
    fillColor();
}
function slideTwo() {
    if (parseInt(sliderTwo.value) - parseInt(sliderOne.value) <= minGap) {
        sliderTwo.value = parseInt(sliderOne.value) + minGap;
    }
    displayValTwo.value = sliderTwo.value;
    fillColor();
}


function inputOne() {
    if (parseInt(displayValTwo.value) - parseInt(displayValOne.value) <= minGap) {
        displayValOne.value = parseInt(displayValTwo.value) - minGap;
    }
    sliderOne.value = displayValOne.value;
    fillColor();
}
function inputTwo() {
    if (parseInt(displayValTwo.value) - parseInt(displayValOne.value) <= minGap) {
        displayValTwo.value = parseInt(displayValOne.value) + minGap;
    }
    sliderTwo.value = displayValTwo.value;
    fillColor();
}


function fillColor() {
    percent1 = (sliderOne.value / sliderMaxValue) * 100;
    percent2 = (sliderTwo.value / sliderMaxValue) * 100;
    sliderTrack.style.background = `linear-gradient(to right, #dadae5 ${percent1}% , #3264fe ${percent1}% , #3264fe ${percent2}%, #dadae5 ${percent2}%)`;
}
