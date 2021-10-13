var menuSlider;
var cloak;

function initializeVariables()
{
    menuSlider = document.getElementById('slide-out-menu');
    cloak = document.getElementById('cloak');
}


function toggleMenu()
{
    if(menuSlider.style.width == '300px')
    {
        menuSlider.style.width = '0px';
        cloak.style.width = '0px';        
    }
    else
    {
        menuSlider.style.width = '300px';
        cloak.style.width = '100%';         
    }   
    
}