var progress;
var personal;
var education;
var work;
var additional;

function initializeProgress()
{
    progress = document.getElementById('progress');
    personal = document.getElementById('personal');
    education = document.getElementById('education');
    work = document.getElementById('work');
    additional = document.getElementById('additional');    
}


function toggleProgress(x, icon)
{
    progress.style.width = x + '%';

    if (icon == "personal")
    {
        personal.style.color = 'green';
        education.style.color = 'black';
        work.style.color = 'black';
        additional.style.color = 'black';
    }
    else if (icon == "education") {
        personal.style.color = 'black';
        education.style.color = 'green';
        work.style.color = 'black';
        additional.style.color = 'black';
    }
    else if (icon == "work") {
        personal.style.color = 'black';
        education.style.color = 'black';
        work.style.color = 'green';
        additional.style.color = 'black';
    }
    else if (icon == "additional") {
        personal.style.color = 'black';
        education.style.color = 'black';
        work.style.color = 'black';
        additional.style.color = 'green';
    }   

}