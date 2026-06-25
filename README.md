<mxfile host="app.diagrams.net" modified="2026-06-25T12:00:00.000Z" agent="Mozilla/5.0" etag="drawio" version="24.7.17" type="device">
  <diagram id="use-case-diagram" name="Use Case Diagram">
    <mxGraphModel dx="1200" dy="800" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="1600" pageHeight="1200">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />

        <!-- Системная граница (рамка) -->
        <mxCell id="system-boundary" value="Система бронирования туров" style="swimlane;whiteSpace=wrap;html=1;fillColor=#f5f5f5;strokeColor=#666666;fontStyle=1;fontSize=14;startSize=30;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="300" y="60" width="900" height="700" as="geometry" />
        </mxCell>

        <!-- === АКТОРЫ (слева) === -->
        <!-- Клиент -->
        <mxCell id="actor-client" value="Клиент" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=12;" vertex="1" parent="1">
          <mxGeometry x="100" y="200" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- Менеджер -->
        <mxCell id="actor-manager" value="Менеджер" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=12;" vertex="1" parent="1">
          <mxGeometry x="100" y="400" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- Администратор -->
        <mxCell id="actor-admin" value="Администратор" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=12;" vertex="1" parent="1">
          <mxGeometry x="100" y="600" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (КЛИЕНТ) === -->
        <mxCell id="uc-register" value="Регистрация" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="80" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-login" value="Авторизация" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="80" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-catalog" value="Просмотр каталога" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="80" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-search" value="Поиск туров" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="80" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-filter" value="Фильтрация" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="140" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-details" value="Детали тура" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="140" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-compare" value="Сравнение туров" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="140" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-favorite" value="Избранное" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="140" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-cart" value="Корзина" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="200" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-order" value="Оформление заказа" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="200" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-calc" value="Расчет стоимости" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="200" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-pay" value="Оплата тура" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="200" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-history" value="История заказов" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="260" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-review" value="Оставить отзыв" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="260" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-read-reviews" value="Читать отзывы" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="260" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-profile" value="Управление профилем" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#dae8fc;strokeColor=#6c8ebf;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="260" width="120" height="40" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (МЕНЕДЖЕР) === -->
        <mxCell id="uc-man-login" value="Авторизация" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="340" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-hotel" value="Управление отелями" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="340" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-rooms" value="Управление номерами" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="340" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-services" value="Управление услугами" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="340" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-photo" value="Загрузка фото" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="400" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-tours" value="Формирование туров" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="400" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-prices" value="Назначение цен" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="400" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-status" value="Статусы туров" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="400" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-hot" value="Горящие туры" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="460" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-discount" value="Управление скидками" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="460" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-confirm" value="Подтверждение бронирований" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="460" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-cancel" value="Отмена бронирований" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="460" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-view-bookings" value="Все бронирования" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="520" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-payments" value="Управление платежами" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="520" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-moderation" value="Модерация отзывов" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="520" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-rating" value="Управление рейтингом" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#d5e8d4;strokeColor=#82b366;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="520" width="120" height="40" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (АДМИНИСТРАТОР) === -->
        <mxCell id="uc-admin-login" value="Авторизация" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="600" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-users" value="Управление пользователями" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="600" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-roles" value="Назначение ролей" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="600" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-ref" value="Управление справочниками" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="600" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-settings" value="Системные настройки" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="380" y="660" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-logs" value="Просмотр логов" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="540" y="660" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-paymethods" value="Управление платежными методами" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="700" y="660" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-insurance" value="Управление страховыми" style="rounded=0;whiteSpace=wrap;html=1;fillColor=#ffe6cc;strokeColor=#d79b00;fontSize=11;" vertex="1" parent="1">
          <mxGeometry x="860" y="660" width="120" height="40" as="geometry" />
        </mxCell>

        <!-- === СВЯЗИ (АКТОР → ПРЕЦЕДЕНТ) === -->
        <!-- Клиент → его прецеденты -->
        <mxCell id="link-client-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-register">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-catalog">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-search">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-filter">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-details">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-compare">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-favorite">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-cart">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-10" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-order">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-11" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-calc">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-12" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-pay">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-history">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-14" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-review">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-15" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-read-reviews">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-16" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#6c8ebf;" edge="1" parent="1" source="actor-client" target="uc-profile">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Менеджер → его прецеденты -->
        <mxCell id="link-manager-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-hotel">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-rooms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-services">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-photo">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-tours">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-prices">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-status">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-hot">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-10" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-discount">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-11" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-confirm">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-12" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-cancel">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-view-bookings">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-14" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-payments">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-15" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-moderation">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-16" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#82b366;" edge="1" parent="1" source="actor-manager" target="uc-man-rating">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Администратор → его прецеденты -->
        <mxCell id="link-admin-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-users">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-roles">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-ref">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-settings">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-logs">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-paymethods">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#d79b00;" edge="1" parent="1" source="actor-admin" target="uc-admin-insurance">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- === ВКЛЮЧЕНИЯ / РАСШИРЕНИЯ (пример) === -->
        <!-- Авторизация включена в оформление заказа (включает) -->
        <mxCell id="include-order-login" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#999999;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-order" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="include-order-login-label" value="«include»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="include-order-login">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-20" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

        <!-- Оплата включает авторизацию -->
        <mxCell id="include-pay-login" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#999999;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-pay" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="include-pay-login-label" value="«include»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="include-pay-login">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-20" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

        <!-- Просмотр деталей расширяет поиск (extend) -->
        <mxCell id="extend-details-search" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#999999;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-details" target="uc-search">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="extend-details-search-label" value="«extend»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="extend-details-search">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-20" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
