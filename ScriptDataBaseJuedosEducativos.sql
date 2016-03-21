CREATE DATABASE juegos_educativos;

CREATE TABLE foto
(
  id integer NOT NULL DEFAULT nextval('foto_id_seq'::regclass),
  foto bytea,
  CONSTRAINT pk_foto PRIMARY KEY (id)
);

CREATE TABLE usuario
(
  id integer NOT NULL DEFAULT nextval('user_id_seq'::regclass),
  nombre text,
  correo text,
  id_foto integer,
  contrasena text,
  usuario text,
  victorias integer DEFAULT 0,
  tiempo_promedio integer DEFAULT 0,
  CONSTRAINT pk_user PRIMARY KEY (id),
  CONSTRAINT fk_user_foto FOREIGN KEY (id_foto)
      REFERENCES public.foto (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT unq_user UNIQUE (usuario)
);