import React from "react";

const Services = () => {
    return <div class="bg-white"> 
    <div class="flex flex-wrap justify-center max-w-screen-xl mx-auto"> 
            <h1 class="text-gray-800 p-6 m-4 text-2xl font-bold mb-4 text-center">Услуги</h1> 
            <div class="bg-gray-800 p-6 m-4 lg:w-full"> 
            <p class="text-white m-2 text-lg">Аренда карта на 1 час: 500руб.</p> 
            <br/> 
            <p class="text-gray-300 m-2 font-semibold text-lg">Наша компания предлагает услугу аренды картов для всего, начиная с простого развлечения на выходных до профессиональных гонок. В нашем распоряжении есть большой ассортимент новых картов высокого качества, которые идеально подходят для дорог, треков и трасс любой сложности.</p> 
            <br/> 
            <a href="/s" class="text-gray-300 m-2 text-lg">Оформить услугу</a> 
        </div> 
        <div class="bg-gray-800 p-6 m-4 lg:w-full"> 
            <p class="text-white m-2 text-lg">Обучение езде на карте 1 час: 1000руб.</p> 
            <br/> 
            <p class="text-gray-300 m-2 font-semibold text-lg">Наша компания предлагает услугу обучения езде на карте для новичков, которые еще не имеют опыта в езде на картинге. Наши профессиональные инструкторы предоставляют обучение как группам, так и отдельным лицам.</p> 
            <br/> 
            <a href="/s" class="text-gray-300 m-2 text-lg">Оформить услугу</a> 
        </div> 
    </div> 
</div> 
}

export default Services;