import React from 'react';
const Footer = () => {
    return (
        <footer class="bg-gray-800 py-8">
        <div class="max-w-screen-lg mx-auto px-4 sm:px-6 lg:px-8">
          <div class="flex flex-col md:flex-row justify-between items-center">
            <div class="text-gray-300">© 2023 Картинг Центр</div>
            <ul class="flex space-x-4 mt-4 md:mt-0">
              <li><a href="/serv" class="text-gray-300 hover:text-white">Услуги</a></li>
              <li><a href="/cont" class="text-gray-300 hover:text-white">Контакты</a></li>
            </ul>
          </div>
        </div>
      </footer>
    )
}

export default Footer;