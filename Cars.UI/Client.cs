﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.UI
{
    class Client
    {
        private decimal moneyaccount;

        public decimal Moneyaccount
        {
            get { return moneyaccount; }
            set { moneyaccount = value; }
        }

        public decimal AccoutTop_up(decimal price)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Стоимость автомобиля: \t{price}р." +
                          $"\nБаланс вашего счета: \t{moneyaccount}р." +
                $"\nНе хватает для покупки:\t{price - moneyaccount}р.\n");

                string fuckingidiot = "кредит";
                decimal top_up;
                Console.Write("Введите сумму, на которую хотите пополнить свой счет, либо напишите \"кредит\", чтобы взять кредит на покупку: ");
                while (true)
                {
                    string result = Console.ReadLine();
                    if (decimal.TryParse(result, out top_up))
                    {
                        if (top_up < 0)
                            Console.Write("!!Ошибка пополнения счета!! Введите корректную сумму пополнения: ");

                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Стоимость автомобиля: \t{price}р." +
                        $"\nБаланс вашего счета: \t{moneyaccount + top_up}р." +
                        $"\nНе хватает для покупки:\t{price - (moneyaccount + top_up)}р.\n");
                            return moneyaccount = moneyaccount + top_up;
                        }
                    }
                    else
                        Console.Write("!!Ошибка пополнения счета!! Введите корректную сумму пополнения: ");
                    if (result.ToLower() == fuckingidiot)
                    {
                        Console.Clear();
                        Console.WriteLine($"Менеджеры салона заботливо ведут вас к сотруднику банка. Ваши документы сканируют и заявление на предоставление кредита заполняют за вас, ваше участие заключается лишь в том, что сотруднику банка нужно вас сфотографировать на веб-камеру своего компьютера.\n" +
                            $"Проходит буквально 5 минут, после чего вас окликает по имени девочка-менеджер банка, ее голос звучит подозрительно дружелюбно и заинтересовано:\n" +
                            $"- Ваш кредит одобрен! Так быстро, здорово! Наверное, вы очень хороший клиент.\n" +
                            $"Подписание кредитного договора проходит под ее полным руководством. Страницы перелистываются одна за другой, вы даже не успеваете разглядеть их номера, лишь ставить подписи внизу.\n" +
                            $"- Замечательно, поздравляю вас с приобретением! - Не меняя улыбки, произносит девочка-сотрудник банка и подзывает менеджеров салона.\n" +
                            $"Далее все события происходят как в тумане, вы словно смотрите на себя со стороны: вот вам вручают ключи от машины, вот поздравляют и провожают, вот вы приезжаете домой и только сейчас додумываетесь посмотреть в свой кредитный договор...\n" +
                            $"\"Два с половиной миллиона страхования жизни!? процентная ставка двадцать пять процентов годовых!? Мараторий на изменение условий и возврат СЖ, лютые штрафы за неуплату!?\" Все эти вопросы к самому себе проносятся в вашей голове вместе с единтсвенно важным: \"О чем я только думал!?\"\n" +
                            $"\nСпоры с салоном и попытки расторгнуть договор с банком ничего не приносят.\n" +
                            $"Вы тратите кучу сил и времени, а непосильные для вас платежи по кредиту так никто не оплачивает.\n" +
                            $"Банк изымает сначала \"ваш\" автомобиль, а затем и ваше жилье за неуплату.\n" +
                            $"\nПроходит несколько лет. Вы осознаете себя в замерзжем дворе-колодце посреди декабря. Вы греетесь от вытяжки, которая гонит на улицу теплый воздух из кухни ресторана, что расположен в этом здании... Но вы все равно замерзаете.\n" +
                            $"Буквально в тот момент, когда последнее тепло на выдохе чуть было не покинуло вместе с жизнью ваше остывшее тело, перед вами возникает светящаяся, лысая, бородатая фигура:\n" +
                            $"- Что, братан, совершил ошибку? Бывает.\n" +
                            $"Вы уже отвыкли, что люди обращают на вас внимание, тем более разговаривают с вами. Лысина этой фигуры сияет словно солнце под светом тусклых дворовых фонарей.\n" +
                            $"- Вставай, я помогу. Все наладится, вот увидишь!\n" +
                            $"Незнакомец поднимает вас за плечи и ставит на ноги. Он сделал это так легко, что вы почуствовали себя невесомым.\n" +
                            $"Этот светящийся человек улыбается вам. Не как девочка-менеджер банка, что пустила вашу жизнь под откос, а искренне.\n" +
                            $"Он кладет ладонь на вашу голову и говорит:\n" +
                            $"-Всего этого не было. У тебя будет еще шанс. Сделай правильный выбор!\n" +
                            $"Вы бы сказали, что в ваших глазах темнеет как перед потерей сознания, только вместо темноты вас окутывает яркий, но не слепящий свет, в котором пропадает ваш ангел хранитель.\n" +
                            $"- Скажи мне, кто ты такой? - Просите вы.\n" +
                            $"- Ты знаешь, кто я. Say my name!\n" +
                            $"И тут в вашей голове само собой всплывает это имя. Вы произносите его:\n" +
                            $"- Валерыч!\n" +
                            $"- You god damn right! Я всегда приматриваю за тобой. Дерзай, братан!\n\n\nНажмите \"Enter\", чтобы дерзать!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
        public decimal TransAction(decimal price)
        {
            while (true)
            {
                if (moneyaccount < price)
                {
                    Console.WriteLine("На вашем счёте недостаточно средств для оплаты. Нажмите \"Enter\", чтобы пополнить его!");
                    Console.ReadLine();
                    AccoutTop_up(price);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{DateTime.Now}\t|| Оплата прошла успешно! состояние вашего счета: {moneyaccount - price}р. ||\n\n" +
                        $"На своем новом и полностью оплаченном автомобиле вы покидаете автосалон и замечаете, как на обочине вам едва заметно улыбается лысый, бородатый незнакомец.\n" +
                        $"Как бы это не прозвучало, лицо незнакомца кажется вам знакомым.\n" +
                        $"У вас появляется хорошее предчувствие на будущее и вы уезжаете в даль... в дааааааааль ангееееел!");
                    return moneyaccount - price;
                }
            }
        }
    }
}
