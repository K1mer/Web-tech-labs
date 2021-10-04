const body = document.body

const NewsData = [
    {
        "Header": "Новость 1",
        "Description" : "Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis! Na screenshote tyt drygoi text!",
        "Content": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis! \nLorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam hic, ipsa, ullam, cupiditate eveniet at voluptate corrupti commodi nobis ratione voluptatem! Vel animi totam cupiditate doloribus ad ab exercitationem officia eveniet impedit? Deleniti quasi nisi consectetur perspiciatis quibusdam nostrum, enim perferendis nam, magni molestias recusandae id libero vitae, repudiandae praesentium.",
    },
    {
        "Header": "Новость 2",
        "Description" : "Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis! V sleduyushei novosti ya vvedu ego vruchnuyu.",
        "Content": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis! \nLorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam hic, ipsa, ullam, cupiditate eveniet at voluptate corrupti commodi nobis ratione voluptatem! Vel animi totam cupiditate doloribus ad ab exercitationem officia eveniet impedit? Deleniti quasi nisi consectetur perspiciatis quibusdam nostrum, enim perferendis nam, magni molestias recusandae id libero vitae, repudiandae praesentium.",
    },
    {
        "Header": "Новость 3",
        "Description" : "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae voluptatum susipit sed delectus facere veritatis autem quisquam unde nam doloribus?",
        "Content": "Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis! \nLorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam hic, ipsa, ullam, cupiditate eveniet at voluptate corrupti commodi nobis ratione voluptatem! Vel animi totam cupiditate doloribus ad ab exercitationem officia eveniet impedit? Deleniti quasi nisi consectetur perspiciatis quibusdam nostrum, enim perferendis nam, magni molestias recusandae id libero vitae, repudiandae praesentium.",
    }
]

CreateNews(NewsData)

function CreateNews(Data) {
    Data.forEach(NewsItem => {
        let news_item_element = document.createElement("div")
        news_item_element.Header = document.createElement("span")
        news_item_element.Description = document.createElement("p")
        news_item_element.OpenButton = document.createElement("button")

        news_item_element.setAttribute("class", "NewsItem")
        news_item_element.Header.setAttribute("class", "NewsHeader")

        news_item_element.Header.innerText = NewsItem.Header
        news_item_element.Description.innerText = NewsItem.Description
        news_item_element.OpenButton.innerText = "Открыть всплывающее окно"

        news_item_element.OpenButton.onclick = function() {
            CreateNotificaion(NewsItem)
        }
        news_item_element.appendChild(news_item_element.Header)
        news_item_element.appendChild(news_item_element.Description)
        news_item_element.appendChild(news_item_element.OpenButton)
        body.appendChild(news_item_element)
    });
}

function CreateNotificaion(Data) {
    let Notification = document.createElement("div")
    Notification.setAttribute("class", "Notification")

    Notification.FullNews = document.createElement("div")
    Notification.FullNews.Header = document.createElement("h1")
    Notification.FullNews.Content = document.createElement("p")

    Notification.FullNews.Header.innerText = Data.Header
    Notification.FullNews.Content.innerText = Data.Header + ": " + Data.Content

    Notification.onclick = function() {
        this.remove()
    }

    Notification.FullNews.appendChild(Notification.FullNews.Header)
    Notification.FullNews.appendChild(Notification.FullNews.Content)
    Notification.appendChild(Notification.FullNews)
    body.appendChild(Notification)
}