<mxfile host="app.diagrams.net" modified="2026-06-25T12:00:00.000Z" agent="Mozilla/5.0" etag="drawio" version="24.7.17" type="device">
  <diagram id="use-case-diagram" name="Use Case Diagram">
    <mxGraphModel dx="1400" dy="900" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="1600" pageHeight="1200">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />

        <!-- Системная граница (рамка, строго как на скрине) -->
        <mxCell id="system-boundary" value="Система бронирования туров" style="swimlane;whiteSpace=wrap;html=1;fillColor=#f0f0f0;strokeColor=#000000;fontStyle=1;fontSize=14;startSize=30;rounded=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="280" y="50" width="920" height="720" as="geometry" />
        </mxCell>

        <!-- === АКТОРЫ (стилизованные человечки, слева) === -->
        <!-- Клиент -->
        <mxCell id="actor-client" value="Клиент" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=12;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="80" y="180" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- Менеджер -->
        <mxCell id="actor-manager" value="Менеджер" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=12;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="80" y="400" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- Администратор -->
        <mxCell id="actor-admin" value="Администратор" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=12;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="80" y="620" width="40" height="80" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (ЭЛЛИПСЫ / ОВАЛЫ) - КЛИЕНТ === -->
        <mxCell id="uc-register" value="Регистрация" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="60" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-login" value="Авторизация" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="500" y="60" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-catalog" value="Просмотр каталога" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="640" y="60" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-search" value="Поиск туров" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="800" y="60" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-filter" value="Фильтрация туров" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="120" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-details" value="Детали тура" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="510" y="120" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-compare" value="Сравнение туров" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="650" y="120" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-favorite" value="Избранное" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="800" y="120" width="100" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-cart" value="Корзина" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="180" width="100" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-order" value="Оформление заказа" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="490" y="180" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-calc" value="Расчёт стоимости" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="650" y="180" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-pay" value="Оплата тура" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="800" y="180" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-history" value="История заказов" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="240" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-review" value="Оставить отзыв" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="510" y="240" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-read-reviews" value="Читать отзывы" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="660" y="240" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-profile" value="Управление профилем" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="810" y="240" width="130" height="40" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (ЭЛЛИПСЫ) - МЕНЕДЖЕР === -->
        <mxCell id="uc-man-login" value="Авторизация" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="320" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-hotel" value="Управление отелями" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="500" y="320" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-rooms" value="Управление номерами" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="660" y="320" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-services" value="Управление услугами" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="820" y="320" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-photo" value="Загрузка фото" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="380" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-tours" value="Формирование туров" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="510" y="380" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-prices" value="Назначение цен" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="670" y="380" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-status" value="Статусы туров" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="820" y="380" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-hot" value="Горящие туры" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="440" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-discount" value="Управление скидками" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="510" y="440" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-confirm" value="Подтверждение бронирований" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="670" y="440" width="150" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-cancel" value="Отмена бронирований" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="850" y="440" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-view-bookings" value="Все бронирования" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="500" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-payments" value="Управление платежами" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="520" y="500" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-moderation" value="Модерация отзывов" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="680" y="500" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-man-rating" value="Управление рейтингом" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="840" y="500" width="130" height="40" as="geometry" />
        </mxCell>

        <!-- === ПРЕЦЕДЕНТЫ (ЭЛЛИПСЫ) - АДМИНИСТРАТОР === -->
        <mxCell id="uc-admin-login" value="Авторизация" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="590" width="110" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-users" value="Управление пользователями" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="500" y="590" width="150" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-roles" value="Назначение ролей" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="680" y="590" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-ref" value="Управление справочниками" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="840" y="590" width="150" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-settings" value="Системные настройки" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="360" y="650" width="130" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-logs" value="Просмотр логов" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="520" y="650" width="120" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-paymethods" value="Управление платежными методами" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="670" y="650" width="160" height="40" as="geometry" />
        </mxCell>
        <mxCell id="uc-admin-insurance" value="Управление страховыми" style="ellipse;whiteSpace=wrap;html=1;fillColor=#ffffff;strokeColor=#000000;fontColor=#000000;fontSize=11;fontStyle=0;shadow=0;gradientColor=none;" vertex="1" parent="1">
          <mxGeometry x="860" y="650" width="140" height="40" as="geometry" />
        </mxCell>

        <!-- === СВЯЗИ (АКТОР → ПРЕЦЕДЕНТ) === -->
        <!-- Клиент → его прецеденты -->
        <mxCell id="link-client-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-register">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-catalog">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-search">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-filter">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-details">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-compare">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-favorite">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-cart">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-10" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-order">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-11" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-calc">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-12" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-pay">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-history">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-14" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-review">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-15" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-read-reviews">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-client-16" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-client" target="uc-profile">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Менеджер → его прецеденты -->
        <mxCell id="link-manager-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-hotel">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-rooms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-services">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-photo">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-tours">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-prices">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-status">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-9" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-hot">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-10" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-discount">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-11" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-confirm">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-12" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-cancel">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-13" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-view-bookings">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-14" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-payments">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-15" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-moderation">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-manager-16" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-manager" target="uc-man-rating">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Администратор → его прецеденты -->
        <mxCell id="link-admin-1" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-2" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-users">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-3" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-roles">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-4" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-ref">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-5" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-settings">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-6" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-logs">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-7" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-paymethods">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="link-admin-8" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;" edge="1" parent="1" source="actor-admin" target="uc-admin-insurance">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- === ВКЛЮЧЕНИЯ / РАСШИРЕНИЯ (пунктирные линии, чёрно-белые) === -->
        <!-- Авторизация включается в оформление заказа -->
        <mxCell id="include-order-login" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-order" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="include-order-login-label" value="«include»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;fontColor=#000000;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="include-order-login">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-15" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

        <!-- Авторизация включается в оплату -->
        <mxCell id="include-pay-login" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-pay" target="uc-login">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="include-pay-login-label" value="«include»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;fontColor=#000000;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="include-pay-login">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-15" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

        <!-- Детали тура расширяют поиск -->
        <mxCell id="extend-details-search" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeColor=#000000;strokeWidth=1;dashed=1;labelBackgroundColor=#ffffff;fontSize=10;" edge="1" parent="1" source="uc-details" target="uc-search">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="extend-details-search-label" value="«extend»" style="edgeLabel;html=1;align=center;verticalAlign=middle;resizable=0;points=[];fontSize=10;fontColor=#000000;labelBackgroundColor=#ffffff;" vertex="1" connectable="0" parent="extend-details-search">
          <mxGeometry x="-0.1" y="1" relative="1" as="geometry">
            <mxPoint x="-15" y="-9" as="offset" />
          </mxGeometry>
        </mxCell>

      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
