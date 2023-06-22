import React from "react";

const Header = () => {
    return <nav class="flex justify-between py-4 px-6 bg-gray-100">
    <a href="/home" class="text-gray-800 hover:text-gray-800 font-bold">Картинг центр</a>
    <div class="flex space-x-4">
      <a  href="/cont" class="text-gray-800 hover:text-gray-800 hover:underline font-medium">Контакты</a>
      <a href="/serv" class="text-gray-800 hover:text-gray-800 hover:underline font-medium">Услуги</a>
      <a  href="/s" class="text-gray-800 hover:text-gray-800 hover:underline font-medium">Личный кабинет</a>
    </div>
  </nav>
}

export default Header;

