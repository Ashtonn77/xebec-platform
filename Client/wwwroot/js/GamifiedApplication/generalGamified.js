var menuSlider;
var cloak;
var innerSlider;

function initializeVariables()
{
    menuSlider = document.getElementById('slide-out-menu');
    cloak = document.getElementById('cloak');
    innerSlider = document.getElementById('slider-container');    
}


function toggleMenu()
{
    if(menuSlider.style.width == '300px')
    {
        menuSlider.style.width = '0px';
        cloak.style.width = '0px';
        innerSlider.style.display = 'none';
    }
    else
    {
        menuSlider.style.width = '300px';
        cloak.style.width = '100%';
        innerSlider.style.display = 'block';
    }   
    
}

