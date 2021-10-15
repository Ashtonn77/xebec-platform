var progress;

function initializeProgress()
{
    progress = document.getElementById('progress');
}


function toggleProgress(x)
{
    progress.style.width = progress.style.width + x + '%';    
}